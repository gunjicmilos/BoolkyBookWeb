namespace BoolkyBook.Models.ViewModels;

public class ShoppingCartVM
{
    public IEnumerable<ShoppingCart> ListCart { get; set; }
    //deleted this property because it now exists in OrderHeader model as OrderTotal 
    //public double CartTotal { get; set; }
    public OrderHeader OrderHeader { get; set; }
}