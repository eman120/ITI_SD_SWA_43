using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketsReservation.DAL.Data.Models;

namespace TicketsReservation.DAL.Repos
{
    public interface IDeveloperRepo
    {
        public IEnumerable<Developer> GetAll();
        public void Delete(int Id);
        public Developer GetById(int DeveloperId);
        public void AddDeveloper(Developer developer);
        public void UpdateDeveloper(int Id, Developer developer);
        int SaveChanges();
        IEnumerable<Developer> GetDevsByIds(int[] Ids);
    }
}
