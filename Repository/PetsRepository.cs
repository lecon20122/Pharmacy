using Microsoft.EntityFrameworkCore;
using Pharmacy.Data;
using Pharmacy.Models;

namespace Pharmacy.Repository
{
    public class PetsRepository : IPets
    {
        private readonly ApplicationDbContext _context;

        public PetsRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Create(Pet pet)
        {
            _context.Add(pet);
            _context.SaveChanges();
        }

        public void Delete(int? id)
        {
            var pet = _context.Pet.Find(id);

            if (pet != null)
            {
                _context.Pet.Remove(pet);
                _context.SaveChanges();
            }

        }

        public void Edit(Pet pet)
        {
            _context.Update(pet);
            _context.SaveChangesAsync();
        }

        public List<Pet>? GetAll(int? id, string? searchName)
        {
            if (searchName is null && !id.HasValue)
            {
                return _context.Pet.ToList();
            }

            var pets = _context.Pet.Where(p => p.Name.Contains(searchName) || p.Id == id);

            return pets.ToList();
        }



        public Pet GetPet(int id)
        {
            var pet = _context.Pet
                .Include(p => p.User)
                .Include(p => p.Prescription)
                .Include(p => p.Report)
                .FirstOrDefault(m => m.Id == id);

            if (pet is null) throw new Exception("Not found");

            return pet;
        }

        public List<Pet>? GetUserPets(int? id, string? searchName, int userId)
        {
            if (searchName is null && !id.HasValue)
            {
                return _context.Pet
                    .Where(p => p.UserId == userId)
                    .Include(p => p.Report)
                    .Include(p => p.Prescription)
                    .ToList();
            }

            return _context.Pet
                .Where(p => p.Name.Contains(searchName) || p.Id == id && p.UserId == userId)
                .Include(p => p.Report)
                .Include(p => p.Prescription)
                .ToList();
        }
    }
}
