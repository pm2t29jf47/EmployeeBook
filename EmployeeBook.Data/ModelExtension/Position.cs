using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeBook.Data
{
    public partial class Position
    {
        public IQueryable<Skill> Skills
        {
            get { return PositionSkills.Select(x => x.Skill).AsQueryable(); }
        }

        public bool HasSkill(Skill skill)
        {
            return Skills.Any(x => x == skill);
        }

        public void AddSkill(Skill skill)
        {
            if(HasSkill(skill)) throw new DuplicateInCollectionException(BusinessObjectEnum.Skill);

            PositionSkills.Add(new PositionSkill {Skill = skill});
        }
    }
}
