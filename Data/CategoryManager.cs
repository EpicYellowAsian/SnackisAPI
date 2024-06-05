using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SnackisAPI.Data
{
    public class CategoryManager
    {
        private readonly MyDbContext _dbContext;
        
        public CategoryManager(MyDbContext dbContext)
        {
            _dbContext = dbContext; 
        }

        public async Task<List<Models.Category>> GetCategories()
        {
            List<Models.Category> categories = await _dbContext.Category.ToListAsync();

            return categories;
        }

        //public async Task AddCategory(Category category)
        //{
        //    await _context.Category.AddAsync(category);
        //    await _context.SaveChangesAsync();
        //}
    }
}
