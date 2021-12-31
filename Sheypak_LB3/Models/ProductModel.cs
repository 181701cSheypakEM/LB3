using System.ComponentModel;

namespace Sheypak_LB3.Models
{
    public class ProductModel
    {
        [DisplayName("Идентификатор")]
        public int Id { get; set; }

        [DisplayName("Название")]
        public string Name { get; set; }

        [DisplayName("Цена")]
        public string Price { get; set; }

        [DisplayName("Описание")]
        public string Description { get; set; }
    }
}
