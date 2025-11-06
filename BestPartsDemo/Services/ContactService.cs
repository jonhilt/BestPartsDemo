using BestPartsDemo.Data;
using BestPartsDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace BestPartsDemo.Services;

public interface IContactService
{
    Task<List<Contact>> GetAllContactsAsync();
    Task<Contact?> GetContactByIdAsync(int id);
    Task<Contact> AddContactAsync(Contact contact);
    Task<Contact?> UpdateContactAsync(Contact contact);
    Task<bool> DeleteContactAsync(int id);
}

public class ContactService : IContactService
{
    private readonly ContactDbContext _context;

    public ContactService(ContactDbContext context)
    {
        _context = context;
    }

    public async Task<List<Contact>> GetAllContactsAsync()
    {
        return await _context.Contacts.ToListAsync();
    }

    public async Task<Contact?> GetContactByIdAsync(int id)
    {
        return await _context.Contacts.FindAsync(id);
    }

    public async Task<Contact> AddContactAsync(Contact contact)
    {
        _context.Contacts.Add(contact);
        await _context.SaveChangesAsync();
        return contact;
    }

    public async Task<Contact?> UpdateContactAsync(Contact contact)
    {
        var existing = await _context.Contacts.FindAsync(contact.Id);
        if (existing == null)
            return null;

        existing.Name = contact.Name;
        existing.Email = contact.Email;
        existing.Phone = contact.Phone;
        existing.Company = contact.Company;
        existing.Role = contact.Role;

        await _context.SaveChangesAsync();
        return existing;
    }

    public async Task<bool> DeleteContactAsync(int id)
    {
        var contact = await _context.Contacts.FindAsync(id);
        if (contact == null)
            return false;

        _context.Contacts.Remove(contact);
        await _context.SaveChangesAsync();
        return true;
    }
}