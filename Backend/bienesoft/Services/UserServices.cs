using bienesoft.Models;

namespace bienesoft.Services
{
    public class UserServices
    {
        private readonly AppDbContext _context;
        public UserServices(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<LearnerModel> GetLearnerModels() 
        {
            return _context.learners.ToList();
        }
    }
}
