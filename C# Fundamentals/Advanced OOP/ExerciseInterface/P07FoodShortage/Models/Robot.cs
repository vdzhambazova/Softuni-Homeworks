using P07FoodShortage.Interfaces;

namespace P07FoodShortage.Models
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
