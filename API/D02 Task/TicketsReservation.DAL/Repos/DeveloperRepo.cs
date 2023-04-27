using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketsReservation.DAL.Data.Context;
using TicketsReservation.DAL.Data.Models;

namespace TicketsReservation.DAL.Repos
{
    public class DeveloperRepo : IDeveloperRepo
    {
        private readonly TicketReservationContext _context;
        public DeveloperRepo(TicketReservationContext context)
        {
            _context = context;
        }
        public IEnumerable<Developer> GetAll()
        {
            if (_context.developers != null)
            {
                return
                _context.developers.ToList();
            }
            else
                return Enumerable.Empty<Developer>();
        }

        public void AddDeveloper(Developer Developer)
        {
            if (Developer != null)
            {
                _context.developers.Add(Developer);
                _context.SaveChanges();
            }
            else return;
        }

        public void Delete(int Id)
        {
            var Developer = _context.developers.Find(Id);
            if (Developer != null)
            {
                _context.developers.Remove(Developer);
                _context.SaveChanges();
            }
            else
                return;
        }

        public Developer GetById(int DeveloperId)
        {
            return _context.developers.Find(DeveloperId) ?? new Developer();
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public void UpdateDeveloper(int Id, Developer Developer)
        {
            var tk = _context.developers.Find(Id);
            if (tk != null)
            {
                tk.Name = Developer.Name;
                _context.SaveChanges();

            }
        }

        public IEnumerable<Developer> GetDevsByIds(int[] Ids)
        {
            return _context.Set<Developer>().Where(d => Ids.Contains(d.Id));
        }
    }
}
