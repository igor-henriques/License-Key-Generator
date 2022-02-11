namespace License_Key_Generator.Repositories;

internal class LicenseRepository : ILicenseRepository
{
    private readonly MySqlConnection context = DbContext.Get();

    public async Task<IEnumerable<CoreLicense>> GetAllAsync()
    {
        const string sql = "SELECT * FROM CoreLicense ORDER BY User,Hwid ASC";

        return await context.QueryAsync<CoreLicense>(sql);
    }

    public async Task InsertAsync(string licenseKey)
    {
        const string sql = "INSERT into CoreLicense(Licensekey,Hwid,Active,Validade,Product) VALUES (@Licensekey,@Hwid,@Active,@Validade,@Product)";

        await context.ExecuteAsync(sql, new
        {
            Licensekey = licenseKey,
            Hwid = "0",
            Active = true,
            Product = Product.Nenhum,
            User = string.Empty,
            Validade = DateTime.Now.Date.AddMonths(1)
        });
    }

    public async Task<IEnumerable<CoreLicense>> GetAllByStateAsync(bool state)
    {
        const string sql = "SELECT * FROM CoreLicense WHERE Active=@Active";

        return await context.QueryAsync<CoreLicense>(sql, new { Active = state });
    }

    public async Task UpdateStatus(CoreLicense license)
    {
        string sql = "UPDATE CoreLicense SET Active=@Active WHERE Licensekey=@Licensekey";

        await context.ExecuteAsync(sql, new { Active = license.Active, Licensekey = license.Licensekey });
    }

    public async Task UpdateAll(CoreLicense license)
    {
        string sql = "UPDATE CoreLicense SET Licensekey=@LicenseKey, Hwid=@Hwid, Active=@Active, Validade=@Validade, Product=@Product WHERE Licensekey=@Licensekey";

        await context.ExecuteAsync(sql, license);
    }

    public async Task Delete(List<string> licenseKeys)
    {
        string query = $"DELETE FROM CoreLicense WHERE Licensekey IN ('{string.Join("','", licenseKeys)}')";

        await context.ExecuteAsync(query);
    }

    public async Task<IEnumerable<CoreLicense>> SearchBy(SearchOption option, string text)
    {
        string query = $"SELECT * FROM CoreLicense WHERE {(option.Equals(SearchOption.Username) ? $"User LIKE '%{text}%'" : $"Licensekey='%{text}%'")}";

        return await context.QueryAsync<CoreLicense>(query);
    }
}