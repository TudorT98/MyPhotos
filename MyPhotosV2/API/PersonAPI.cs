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
        public Person GetPersonByName(string name)
        {
            using (PhotoContainer ctx = new PhotoContainer())
            {
                var person = from p in ctx.PersonSet where (p.FirstName == name) select p;
                if (person != null)
                    return person.FirstOrDefault();
                return null;
            }
        }
        public int GetIdByName(string name)
        {
            using (PhotoContainer ctx = new PhotoContainer())
            {
                var id = from p in ctx.PersonSet where (p.FirstName == name) select p.Id;
                return (int)(id.FirstOrDefault());
            }
        }
        public bool updatePerson(int id,string FirstName,string LastName,string Age)
        {
          using (PhotoContainer ctx = new PhotoContainer())
           {
               var result = ctx.PersonSet.SingleOrDefault(p => p.Id == id);
                if (result != null)
                  {
                      result.FirstName = FirstName;
                      result.LastName = LastName;
                      result.Age = Age;
                      return true;
                   }
                    return false;
                }
           }

        public bool DeletePerson(int id)
        {
            using (PhotoContainer ctx = new PhotoContainer())
            {
                ctx.Database.ExecuteSqlCommand("Delete From People where Id =@p0", id);
                return true;
            }
        }

        public List<Person> GetPeople()
        {
            using (PhotoContainer ctx = new PhotoContainer())
            {
                var people = from l in ctx.PersonSet select l;
                if (people != null)
                    return people.ToList();
                return null;
            }
        }

        public Person GetPersonById(int id)
        {
            using (PhotoContainer ctx = new PhotoContainer())
            {
                var people = from l in ctx.PersonSet where (l.Id == id) select l;
                return people.FirstOrDefault();
            }

        }


    }
    
}

