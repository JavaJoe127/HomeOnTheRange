// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryController.cs" company="HotR">
//   2015
// </copyright>
// <summary>
//   The Inventory Controller.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace HomeOnTheRange.Controllers
{
    using System;
    using System.Net;
    using System.Web.Mvc;

    using Models;
    using Repositories;

    /// <summary>
    /// The Inventory Controller.
    /// </summary>
    public class InventoryController : Controller
    {
        /// <summary>
        /// The repository data context for inventory.
        /// </summary>
        /// <returns>
        /// The <see cref="Inventory"/>.
        /// </returns>
        InventoryRepository repository = new InventoryRepository();

        /// <summary>
        /// The Index.
        /// </summary>
        /// GET: Inventory
        public ActionResult Index()
        {
            return View(repository.GetAll());
        }

        /// <summary>
        /// The Details.
        /// </summary>
        /// <param name="id">
        /// The Id.
        /// </param>
        /// GET: Inventory/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Inventory inventory = repository.Get(id.Value);
            if (inventory == null)
            {
                return HttpNotFound();
            }

            return View(inventory);
        }

        /// <summary>
        /// The Create.
        /// </summary>
        /// GET: Inventory/Create
        public ActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// The Create HTTP Post.
        /// </summary>
        /// POST: Inventory/Create
        /// To protect from overposting attacks, enabled the specific properties to bind to 
        /// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Product,BrandName,PurchaseDate,ExpirationDate,Quantity,Price,Type,Property,Description")] Inventory inventory)
        {
            if (ModelState.IsValid)
            {
                inventory.ID = Guid.NewGuid();
                repository.Add(inventory);
                repository.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(inventory);
        }

        /// <summary>
        /// The Edit.
        /// </summary>
        /// <param name="id">
        /// The Id.
        /// </param>
        /// GET: Inventory/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Inventory inventory = repository.Get(id.Value);
            if (inventory == null)
            {
                return HttpNotFound();
            }
            return View(inventory);
        }

        /// <summary>
        /// The Edit HTTP Post.
        /// </summary>
        /// <param name="inventory">
        /// The inventory.
        /// </param>
        /// POST: Inventory/Edit/5
        /// To protect from overposting attacks, enable the specific properties to bind to
        /// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Product,BrandName,PurchaseDate,ExpirationDate,Quantity,Price,Type,Property,Description")] Inventory inventory)
        {
            if (!ModelState.IsValid)
            {
                return View(inventory);
            }

            repository.Save(inventory);
            return RedirectToAction("Index");
        }

        /// <summary>
        /// The Delete.
        /// </summary>
        /// <param name="id">
        /// The Id.
        /// </param>
        /// GET: Inventory/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Inventory inventory = repository.Get(id.Value);
            if (inventory == null)
            {
                return HttpNotFound();
            }

            return View(inventory);
        }

        /// <summary>
        /// The Delete Confirmed HTTP Post.
        /// </summary>
        /// <param name="id">
        /// The Id.
        /// </param>
        /// POST: Inventory/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            Inventory inventory = repository.Get(id);
            repository.Remove(inventory);
            repository.SaveChanges();
            return RedirectToAction("Index");
        }

        /// <summary>
        /// The Dispose.
        /// </summary>
        /// <param name="disposing">
        /// The disposing helper.
        /// </param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                repository.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}
