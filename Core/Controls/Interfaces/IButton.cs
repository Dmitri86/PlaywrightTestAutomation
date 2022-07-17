using System.Threading.Tasks;

namespace Core.Controls.Interfaces
{
    public interface IButton
    {
        public Task Click();

        public Task<string> GetText();
    }
}