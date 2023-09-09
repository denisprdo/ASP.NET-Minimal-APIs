using Flunt.Notifications;
using Flunt.Validations;

namespace MiniTodo.ViewModels
{
    public class CreateTodoViewModels : Notifiable<Notification>
    {
        public string Title { get; set; }

        public Todo MapTo()
        {
            var contract = new Contract<Notification>()
                .Requires()
                .IsNotNull(Title, "Informe o título da tarefa")
                .IsGreaterThan(Title, 5, "O título deve conter mais de 5 caractéres");

            AddNotifications(contract);

            return new Todo(Guid.NewGuid(), Title, false);
        }
    }
}
