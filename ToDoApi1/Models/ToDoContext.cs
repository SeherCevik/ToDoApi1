using Microsoft.EntityFrameworkCore;

namespace ToDoApi1.Models   
{
    //veritabanı bağlamını eklemek için oluşturduğumuz sınıf (ToDoContext)
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> option) : base(option)
        {

        }
        public DbSet<ToDoItem> ToDoItems {get; set;}
        //          <MODEL ADI> Controller da ya da api nin farlı yerlerinde veritabanına erişmek için kullanacağımız isim
        //Bu kodları startup ta tanımlamamız lazım (startupın içinde yer alan veriler artık programcs nin içinde) güncellendi!
       
    }
}
