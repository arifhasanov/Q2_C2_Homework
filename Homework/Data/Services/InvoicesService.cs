namespace Homework.Data.Services;

public class InvoicesService : IService<Invoice, InvoiceVM>
{
    private AppDbContext _context;

    public InvoicesService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Invoice>> Create(InvoiceVM invoice)
    {
        var _invoice = new Invoice()
        {
            DateFrom = invoice.DateFrom,
            DateTo = invoice.DateTo,
            InvoiceDate = invoice.InvoiceDate,
        };
        await _context.Invoices.AddAsync(_invoice);
        await _context.SaveChangesAsync();
        return await _context.Invoices.ToListAsync();
    }

    public async Task<IList<Invoice>> GetAll()
    {
        return await _context.Invoices.ToListAsync();
    }

    public async Task<Invoice> Get(int Id)
    {
        return await _context.Invoices.FirstOrDefaultAsync(x => x.Id == Id);
    }

    public async Task<Invoice> Update(int Id, InvoiceVM invoice)
    {
        var _invoice = await _context.Invoices.FirstOrDefaultAsync(x => x.Id == Id);
        if (_invoice != null)
        {
            _invoice.DateFrom = invoice.DateFrom;
            _invoice.DateTo = invoice.DateTo;
            _invoice.InvoiceDate = invoice.InvoiceDate;
            _context.SaveChanges();
        }
        return _invoice;
    }

    public async Task Delete(int Id)
    {
        var _invoice = await _context.Invoices.FirstOrDefaultAsync(x => x.Id == Id);
        if (_invoice != null)
        {
            _context.Invoices.Remove(_invoice);
            _context.SaveChangesAsync();
        }
    }
}
