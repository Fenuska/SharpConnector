﻿// (c) 2020 Francesco Del Re <francesco.delre.87@gmail.com>
// This code is licensed under MIT license (see LICENSE.txt for details)
using System.Threading.Tasks;

namespace SharpConnector.Interfaces
{
    /// <summary>
    /// Operations interface.
    /// </summary>
    /// <typeparam name="T">Payload object type.</typeparam>
    public interface IOperations<T>
    {
        T Get(string key);
        Task<T> GetAsync(string key);
        bool Insert(string key, T value);
        Task<bool> InsertAsync(string key, T value);
        bool Delete(string key);
        Task<bool> DeleteAsync(string key);
        bool Update(string key, T value);
        Task<bool> UpdateAsync(string key, T value);
    }
}
