namespace License_Key_Generator.Interfaces;

internal interface ILicenseRepository
{
    Task Delete(List<string> licenseKeys);
    Task<IEnumerable<CoreLicense>> GetAllAsync();
    Task<IEnumerable<CoreLicense>> GetAllByStateAsync(bool state);
    Task InsertAsync(string licenseKey);
    Task<IEnumerable<CoreLicense>> SearchBy(SearchOption option, string text);
    Task UpdateStatus(CoreLicense license);
    Task UpdateAll(CoreLicense license);
}