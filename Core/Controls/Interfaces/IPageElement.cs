using System.Threading.Tasks;

namespace Core.Controls.Interfaces
{
    public interface IPageElement
    {
        public Task<bool> IsVisible();
        public Task<bool> IsEnable();
    }
}