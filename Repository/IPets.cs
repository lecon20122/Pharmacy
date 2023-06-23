using Pharmacy.Models;

namespace Pharmacy.Repository
{
    public interface IPets
    {
        List<Pet>? GetAll(int? id, string? searchName);
        Pet GetPet(int id);
        void Create(Pet pet);
        void Edit(Pet pet);
        void Delete(int? id);
        List<Pet>? GetUserPets(int? id, string? searchName, int userId);
    }
}
