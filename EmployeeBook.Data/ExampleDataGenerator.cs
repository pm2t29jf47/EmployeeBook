using System;
using System.Linq;

namespace EmployeeBook.Data
{
    public static class ExampleDataGenerator
    {
        private static Employee ivan;
        private static Employee grigory;
        private static Position junior;
        private static Position designer;
        private static Position technicalWriter;
        private static Skill cpp;
        private static Skill cSharp;
        private static Skill cSharpBase;
        private static Skill javaBase;
        private static Skill xaml;
        private static Skill css;
        private static Skill javadoc;

        private static Employee Ivan => ivan ?? (ivan = new Employee
        {
            FirstName = "Иван",
            ThirdName = "Сидорович",
            SecondName = "Петров",
            Comment = "Тестовый работник 1"
        });

        private static Employee Grigory => grigory ?? (grigory = new Employee
        {
            FirstName = "Григорий",
            ThirdName = "Пантелеевич",
            SecondName = "Мелехов",
            Comment = "Тестовый работник 2"
        });

        private static Position Junior => junior ?? (junior = new Position
        {
            Name = "Младший разработчик",
            Comment = "Комментарий"
        });

        private static Position Designer => designer ?? (designer = new Position
        {
            Name = "Дизайнер",
            Comment = ""
        });

        private static Position TechnicalWriter => technicalWriter ?? (technicalWriter = new Position
        {
            Name = "Технический писатель",
            Comment = "Документация, тз и тд"
        });

        private static Skill Cpp => cpp ?? (cpp = new Skill
        {
            Name = "C++",
            Comment = ""
        });

        private static Skill CSharp => cSharp ?? (cSharp = new Skill
        {
            Name = "C#",
            Comment = ""
        });

        private static Skill CSharpBase => cSharpBase ?? (cSharpBase = new Skill
        {
            Name = "C# Базовый",
            Comment = ""
        });

        private static Skill JavaBase => javaBase ?? (javaBase = new Skill
        {
            Name = "Java Базовый",
            Comment = ""
        });

        private static Skill Xaml => xaml ?? (xaml = new Skill
        {
            Name = "XAML",
            Comment = ""
        });

        private static Skill Css => css ?? (css = new Skill
        {
            Name = "CSS",
            Comment = ""
        });

        private static Skill Javadoc => javadoc ?? (javadoc = new Skill
        {
            Name = "Javadoc",
            Comment = "NDoc, Doxygen"
        });

        public static void InsertExampleData(EmployeeBookEntities context)
        {
            RemovePreviousData(context);
            InsertEmployees(context);
            InsertPositions(context);
            InsertSkills(context);
            AddSkillsToPositions();
            AddPositionsToEmployees();
            AddSkillsToEmployees();
        }

        private static void RemovePreviousData(EmployeeBookEntities context)
        {
            context.EmployeePositionSkills.ToList().ForEach(x => context.EmployeePositionSkills.Remove(x));
            context.EmployeePositions.ToList().ForEach(x => context.EmployeePositions.Remove(x));
            context.PositionSkills.ToList().ForEach(x => context.PositionSkills.Remove(x));
            context.Employees.ToList().ForEach(x => context.Employees.Remove(x));
            context.Positions.ToList().ForEach(x => context.Positions.Remove(x));
            context.Skills.ToList().ForEach(x => context.Skills.Remove(x));
        }

        private static void InsertEmployees(EmployeeBookEntities context)
        {
            context.Employees.Add(Ivan);
            context.Employees.Add(Grigory);
        }

        private static void InsertPositions(EmployeeBookEntities context)
        {
            context.Positions.Add(Junior);
            context.Positions.Add(TechnicalWriter);
            context.Positions.Add(Designer);
        }

        private static void AddSkillsToEmployees()
        {
            Ivan.AddSkill(Junior, Cpp, DateTime.Now);
            Ivan.AddSkill(Junior, CSharpBase, DateTime.Now);
            Ivan.AddSkill(TechnicalWriter, CSharpBase, DateTime.Now);
            Ivan.AddSkill(TechnicalWriter, Javadoc, DateTime.Now);
            Grigory.AddSkill(Designer, Xaml, DateTime.Now);
            Grigory.AddSkill(Designer, Css, DateTime.Now);
            Grigory.AddSkill(Designer, JavaBase, DateTime.Now);
            Grigory.AddSkill(TechnicalWriter, JavaBase, DateTime.Now);
            Grigory.AddSkill(TechnicalWriter, Javadoc, DateTime.Now);
        }

        private static void AddPositionsToEmployees()
        {
            Ivan.AddPosition(Junior, DateTime.Now);
            Ivan.AddPosition(TechnicalWriter, DateTime.Now);
            Grigory.AddPosition(Designer, DateTime.Now);
            Grigory.AddPosition(TechnicalWriter, DateTime.Now);
        }

        private static void AddSkillsToPositions()
        {
            Junior.AddSkill(Cpp);
            Junior.AddSkill(CSharp);
            Junior.AddSkill(CSharpBase);
            Junior.AddSkill(JavaBase);
            TechnicalWriter.AddSkill(CSharpBase);
            TechnicalWriter.AddSkill(JavaBase);
            TechnicalWriter.AddSkill(Javadoc);
            Designer.AddSkill(Xaml);
            Designer.AddSkill(Css);
            Designer.AddSkill(JavaBase);
        }

        private static void InsertSkills(EmployeeBookEntities context)
        {
            context.Skills.Add(Cpp);
            context.Skills.Add(CSharp);
            context.Skills.Add(CSharpBase);
            context.Skills.Add(JavaBase);
            context.Skills.Add(Xaml);
            context.Skills.Add(Css);
            context.Skills.Add(Javadoc);
        }
    }
}