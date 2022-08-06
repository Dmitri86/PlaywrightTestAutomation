using System.Threading.Tasks;

namespace Core.Controls.Interfaces
{
    public interface IMenuItem
    {
        public Task<string> GetText();

        public Task Click();
    }
}