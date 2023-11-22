public class SeedData

{

    public static void Init() //
    {
        TodoContext context = new TodoContext();

        // Add Todo
        Todo todo1 = new Todo
        {
            Task = "Task 1",
            Completed = false,
            Deadline = DateTime.Parse("2021-09-01"),
        };
        Todo todo2 = new Todo
        {
            Task = "Task 2",
            Completed = false,
            Deadline = DateTime.Parse("2021-09-02"),
        };
        Todo todo3 = new Todo
        {
            Task = "Task 3",
            Completed = false,
            Deadline = DateTime.Parse("2021-09-03"),
        };
        context.Todo.AddRange(
            todo1,
            todo2,
            todo3
        );
        context.SaveChanges(); // A NE PAS OUBLIER !!!!!!!!!!!!!!!!!!!!!
    }
}

