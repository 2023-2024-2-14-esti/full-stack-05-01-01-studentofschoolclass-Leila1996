namespace Kreta.HttpService.Services
{
    public interface IHeadTeacherService
    {

        public Task<int> GetNumberOfHeadTeacher(bool isAssistant);
    }
}
