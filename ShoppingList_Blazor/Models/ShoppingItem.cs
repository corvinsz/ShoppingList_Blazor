namespace ShoppingList_Blazor.Models;

public record ShoppingItem(Guid Id, string Description)
{
    public bool IsChecked { get; set; } = false;
}
