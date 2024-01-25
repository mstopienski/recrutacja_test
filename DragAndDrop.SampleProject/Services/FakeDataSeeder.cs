using DragAndDrop.SampleProject.Model;

namespace DragAndDrop.SampleProject.Services
{
    public static class FakeDataSeeder
    {
        public static List<ContainerBase> SeedGroups()
        {
            List<ContainerBase> temp = new();
            temp.Add(new ContainerBase
            {
                Id = Guid.NewGuid().ToString(),
                Name = "1",
                Icon = "check_box_outline_blank"
            });
            temp.Add(new ContainerBase
            {
                Id = Guid.NewGuid().ToString(),
                Name = "2",
                Icon = "grade"
            });
            temp.Add(new ContainerBase
            {
                Id = Guid.NewGuid().ToString(),
                Name = "3",
                Icon = "visibility"
            });
            temp.Add(new ContainerBase
            {
                Id = Guid.NewGuid().ToString(),
                Name = "4",
                Icon = "change_history"
            });
            temp.Add(new ContainerBase
            {
                Id = Guid.NewGuid().ToString(),
                Name = "5",
                Icon = "person"
            });
            return temp;
        }

        public static List<UserModel> SeedUsers(string containerId)
        {
            List<UserModel> temp  = new();
            temp.Add(new UserModel
            {
                Id = Guid.NewGuid().ToString(),
                FirstName = "Adam",
                LastName = "Kowalski",
                Identifier = containerId,
                City = "Warszawa",
                Photo = "/images/pic1.jpg"
            });
            temp.Add(new UserModel
            {
                Id = Guid.NewGuid().ToString(),
                FirstName = "Maria",
                LastName = "Marionetka",
                Identifier = containerId,
                City = "Kraków",
                Photo = "/images/pic2.jpg"
            });
            temp.Add(new UserModel
            {
                Id = Guid.NewGuid().ToString(),
                FirstName = "Marek",
                LastName = "Marecki",
                Identifier = containerId,
                City = "Kraków",
                Photo = "/images/pic3.jpg"
            });
            temp.Add(new UserModel
            {
                Id = Guid.NewGuid().ToString(),
                FirstName = "Tomasz",
                LastName = "Janowski",
                Identifier = containerId,
                City = "Rzeszów",
                Photo = "/images/pic4.jpg"
            });
            return temp;
        }
    }
}
