using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoanManagementSys.Managers;
using LoanManagementSys.SystemItems;
using LoanManagementSys.Tasks;

namespace LoanManagementSys;

/*
  The task of this thread class is to send request to the controller to
  update the list of products that are on loand as wekk as  the list
  available products on the UI using at certain intervals (e.g 2 seconds).

  Note: loanSys is a reference to an object of the LoanSystem which
  is a class which creates the threads and  also updates the MainForm.
  It has the reference to the listboxes for updating.
*/
public class UpdateGUI : BaseTask
{  
    private LoanSystem loanSystem;
    public MainForm mainForm;

    public UpdateGUI(LoanSystem loanSystem, MainForm mainForm)
    {
        this.loanSystem = loanSystem;
        this.mainForm = mainForm;
    }

    /// <summary>
    /// This method is run by the thread assigned to perform the task. It requests
    /// updating the list of products and the list of items on loan by the controller.
    /// </summary>
    public void Run()
    {       
        while (isRunning)
        {
            UpdateProductListBox();
            UpdateEventListBox();
            Thread.Sleep(1000);
        }
    }
    //Method to refresh the list of available products
    public void ClearProductListBox()
    {
        mainForm.ListItems.Items.Clear();
    }
    //Method to refresh the products on loan
    public void ClearEventListBox()
    {
        mainForm.ListOutput.Items.Clear();
    }

    //Method to update the list of available products for loaning
    public void UpdateProductListBox()
    {
        string[] productInfoStrings = loanSystem.productManager.GetProductInfoStrings();

        if (mainForm.ListItems.InvokeRequired)
        {
            mainForm.ListItems.Invoke(new Action(UpdateProductListBox));
        }
        else
        {
            ClearProductListBox();
            foreach (string productInfoString in productInfoStrings)
            {
                mainForm.UpdateProducts(productInfoString);
            }
        }
    }

    //Method to update the products currently being loaned and show when a new product is added to the system
    public void UpdateEventListBox()
    {
        string[] loanitemInfoStrings = loanSystem.loanItemManager.GetLoanItemInfoStrings();
        string[] addedProductInfoStrings = loanSystem.productManager.GetAddedProductsInfoString();

        if (mainForm.ListOutput.InvokeRequired)
        {
            mainForm.ListOutput.Invoke(new Action(UpdateEventListBox));
        }
        else
        {
            ClearEventListBox();
            foreach (string loanitemInfoString in loanitemInfoStrings)
            {
                mainForm.UpdateEvents(loanitemInfoString);
            }
            foreach (string  addedProductInfoString in addedProductInfoStrings)
            {
                mainForm.UpdateEvents(addedProductInfoString);
            }
        }
    }

}

