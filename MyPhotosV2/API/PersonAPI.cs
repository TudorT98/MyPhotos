using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotosV2
{
    public class PersonAPI
    {
        string FirstName;
        string LastName;
        public void AddPerson(Person person)
        {
            using (PhotoContainer ctx = new PhotoContainer())
            {
                ctx.PersonSet.Add(person);
                ctx.SaveChanges();
            }
        }
        public List<String> GetPeopleName()
        {
            List<string> peopleName = new List<string>();
            using (PhotoContainer ctx = new PhotoContainer())
            {
                var people = (from p in ctx.PersonSet
                              select new DTO.PersonDTO
                              {
                                  FirstName = p.FirstName,
                                  LastName = p.LastName
                              }).ToList();
                if (people != null)
                {
                    for (int i = 0; i < people.Count(); i++)
                    {
                        peopleName.Add(people.ElementAt(i).FirstName + ' ' + people.ElementAt(i).LastName);
                    }
                }
                return peopleName;
            }
        }
    }


}

