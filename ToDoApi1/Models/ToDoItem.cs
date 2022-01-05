namespace ToDoApi1.Models
{
    public class ToDoItem
    {
        public long Id { get; set; }
        public string name { get; set; }
        public string LastName { get; set; }
        //tamamlandı mı sorusunu true false dönecek prop.
        public bool IsComplete { get; set; }

    }
}
