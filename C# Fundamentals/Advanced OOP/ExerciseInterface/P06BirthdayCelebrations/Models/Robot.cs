using P06BirthdayCelebrations.Interfaces;

namespace P06BirthdayCelebrations.Models
{
    class Robot: IIdentifiable
    {
        private string model;

        public Robot(string model, string id)
        {
            this.model = model;
            this.Id = id;
        }
        public string Id { get; set; }

        public string Model
        {
            get
            {
                return model;
            }

            set
            {
                model = value;
            }
        }
    }
}
