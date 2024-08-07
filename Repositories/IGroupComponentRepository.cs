using AppMauiGallery.Models;

namespace AppMauiGallery.Repositories;

public interface IGroupComponentRepository
{
    List<GroupComponent> GetGroupComponent();

    List<Component> GetComponents();
}
