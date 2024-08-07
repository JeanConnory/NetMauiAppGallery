using AppMauiGallery.Models;

namespace AppMauiGallery.Repositories;

public partial class GroupComponentRepository : IGroupComponentRepository
{
    private List<Component> _components;
    private List<GroupComponent> _groupComponents;

    public GroupComponentRepository()
    {
        LoadData();
    }

    public List<Component> GetComponents()
    {
        return _components;
    }

    public List<GroupComponent> GetGroupComponent()
    {
        return _groupComponents;
    }
}
