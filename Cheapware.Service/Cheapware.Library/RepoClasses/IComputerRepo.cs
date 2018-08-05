using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Cheapware.Data.Models;
using Cheapware.Library.Models;
namespace Cheapware.Library.RepoClasses
{
    public interface IComputerRepo
    {
        //Misc Repo Methods
        Task Save();

        //Computer Case Repo Methods
        Task<List<ComputerCase>> GetComputerCases();
        Task<ComputerCase> GetComputerCaseByName(string name);

        //CPU Repo Methods
        Task<List<Cpu>> GetCpus();
        Task<Cpu> GetCpuByName(string name);
                
        //Graphics Card Repo Methods
        Task<List<GraphicsCard>> GetGraphicsCards();
        Task<GraphicsCard> GetGraphicsCardByName(string name);
        
        //Mother Board Repo Methods
        Task<List<MotherBoard>> GetMotherBoards();
        Task<MotherBoard> GetMotherBoardByName(string name);

        //Power Supply Repo Methods
        Task<List<PowerSupply>> GetPowerSupplys();
        Task<PowerSupply> GetPowerSupplyByName(string name);

        //Ram Repo Methods
        Task<List<Ram>> GetRams();
        Task<Ram> GetRamByName(string name);

        //Customer Repo Methods
        Task<List<Customer>> GetCustomers();
        void AddCustomer(Customer customer);
        Task<Customer> GetCustomerById(int id);
        Task<Customer> GetCustomerByName(string name);
        Task<Customer> GetCustomerByUserName(string name);
        //Task<int> GetCustomerIdByUserName(string userName);

        //Hard Drive Repo Methods
        Task<List<HardDrive>> GetHardDrives();
        Task<HardDrive> GetHardDriveByName(string name);

        //Inventory Repo Methods
        Task<List<Inventory>> GetInventoryByCategory(string cat);
        Task<List<Inventory>> GetInventory();
        Task<Inventory> GetProductByName(string name);
        Task<List<Inventory>> GetInventoryByCart(List<string> items);
        //Order Repo Methods
        Task<List<PartsOrder>> GetOrdersByCustomerId(int id);
        void AddOrder(PartsOrder order);
        Task<PartsOrder> GetOrderById(int id);

        //Cart Repo Methods
        Task<List<Inventory>> GetCartByCustomerId(int id);
        void AddCart(Cart cart);
        Task<Cart> GetCartById(int id);
        Task DeleteCartByCustomer(int id);





    }
}
