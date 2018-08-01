using System;
using System.Collections.Generic;
using System.Text;
using Cheapware.Data.Models;
using Cheapware.Library.Models;
namespace Cheapware.Library.RepoClasses
{
    public interface IComputerRepo
    {
        List<ComputerCase> GetComputerCases();
        ComputerCase GetComputerCaseByName(string name);
        List<CPU> GetCpus();
        CPU GetCpuByName(string name);
        void Save();
        List<Customer> GetCustomers();
        void AddCustomer(Customer customer);
        Customer GetCustomerById(int id);
        Customer GetCustomerByName(string name);
        List<GraphicsCard> GetGraphicsCards();
        GraphicsCard GetGraphicsCardByName(string name);
        List<Inventory> GetInventory();
        Inventory GetProductByName(string name);
        List<MotherBoard> GetMotherBoards();
        MotherBoard GetMotherBoardByName(string name);
        List<PowerSupply> GetPowerSupplys();
        PowerSupply GetPowerSupplyByName(string name);
        List<RAM> GetRams();
        RAM GetRamByName(string name);
        Customer GetCustomerByUserName(string name);
        List<HardDrive> GetHardDrives();
        HardDrive GetHardDriveByName(string name);


    }
}
