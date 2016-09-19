﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace EmployeeBook.Data
{
    public class DataProvider : IDataProvider
    {
        private Employee ivan;

        private Employee Ivan => ivan ?? (ivan = new Employee
        {
            FirstName = "Иван",
            ThirdName = "Сидорович",
            SecondName = "Петров",
            Comment = "Тестовый работник 1"
        });

        private Employee grigory;

        private Employee Grigory => grigory ?? (grigory = new Employee
        {
            FirstName = "Григорий",
            ThirdName = "Пантелеевич",
            SecondName = "Мелехов",
            Comment = "Тестовый работник 2"
        });

        private Position junior;

        private Position Junior => junior ?? (junior = new Position
        {
            Name = "Младший разработчик",
            Comment = "Комментарий"
        });

        private Position designer;

        private Position Designer => designer ?? (designer = new Position
        {
            Name = "Дизайнер",
            Comment = ""
        });

        private Position technicalWriter;

        private Position TechnicalWriter => technicalWriter ?? (technicalWriter = new Position
        {
            Name = "Технический писатель",
            Comment = "Документация, тз и тд"
        });

        private Skill cpp;

        private Skill Cpp => cpp ?? (cpp = new Skill
        {
            Name = "C++",
            Comment = ""
        });

        private Skill cSharp;

        private Skill CSharp => cSharp ?? (cSharp = new Skill
        {
            Name = "C#",
            Comment = ""
        });

        private Skill cSharpBase;

        private Skill CSharpBase => cSharpBase ?? (cSharpBase = new Skill
        {
            Name = "C# Базовый",
            Comment = ""
        });

        private Skill javaBase;

        private Skill JavaBase => javaBase ?? (javaBase = new Skill
        {
            Name = "Java Базовый",
            Comment = ""
        });

        private Skill xaml;

        private Skill Xaml => xaml ?? (xaml = new Skill
        {
            Name = "XAML",
            Comment = ""
        });

        private Skill css;

        private Skill Css => css ?? (css = new Skill
        {
            Name = "CSS",
            Comment = ""
        });

        private Skill javadoc;

        private Skill Javadoc => javadoc ?? (javadoc = new Skill
        {
            Name = "Javadoc",
            Comment = "NDoc, Doxygen"
        });

        


        public void InsertExampleData()
        {
            using (var context = new EmployeeBookEntities())
            {
                context.Employees.Add(Ivan);
                context.Employees.Add(Grigory);
                context.Positions.Add(Junior);
                context.Positions.Add(TechnicalWriter);
                context.Positions.Add(Designer);
                context.Skills.Add(Cpp);
                context.Skills.Add(CSharp);
                context.Skills.Add(CSharpBase);
                context.Skills.Add(JavaBase);
                context.Skills.Add(Xaml);
                context.Skills.Add(Css);
                context.Skills.Add(Javadoc);

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

                Ivan.AddPosition(Junior, DateTime.Now);
                Ivan.AddPosition(TechnicalWriter, DateTime.Now);
                Grigory.AddPosition(Designer, DateTime.Now);
            }
        }
    }
}