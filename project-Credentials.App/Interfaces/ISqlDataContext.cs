namespace project_Credentials.App.Interfaces;

public interface ISqlDataContext
{
    Task<IEnumerable<T>> LoadData<T, P>(string storedProcedure, P parameters, string connectionId = "Default");
    Task SaveData<T>(string storedProdedure, T parameters, string connectionId = "Default");
}