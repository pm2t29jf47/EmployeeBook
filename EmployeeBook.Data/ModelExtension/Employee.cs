using System;
using System.Linq;

namespace EmployeeBook.Data
{
   public partial class Employee
    {
       public IQueryable<Position> Positions
       {
           get { return EmployeePositions.Select(x => x.Position).AsQueryable(); }
       }

       public bool HasPosition(Position position)
       {
           return Positions.Any(x => x == position);
       }

       public bool HasSkill(Position position, Skill skill)
       {
           if (!HasPosition(position)) throw new NotFindInCollectionException(BusinessObjectEnum.Position);
           return EmployeePositionSkills.Any(x => x.PositionSkill.Position == position && x.PositionSkill.Skill == skill);
       }

       public void AddPosition(Position position, DateTime date)
       {
           if (HasPosition(position)) throw new DuplicateInCollectionException(BusinessObjectEnum.Position);

           EmployeePositions.Add(new EmployeePosition
           {
               Position = position,
               AssignmentDate = date
           });
       }

       public void AddSkill(Position position, Skill skill, DateTime date)
       {
            if(HasSkill(position, skill)) throw new DuplicateInCollectionException(BusinessObjectEnum.Skill);
            if(!position.HasSkill(skill)) throw new NotFindInCollectionException(BusinessObjectEnum.Skill);

           EmployeePositionSkills.Add(new EmployeePositionSkill
           {
               PositionSkill = position.PositionSkills.Single(x => x.Skill == skill),
               AssignmentDate = date
           });
       }
    }
}
