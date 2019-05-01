﻿using BLL.Interface;
using Component.Utility;
using DAL;
using System;
using System.Collections.Generic;
using System.Text;
using Wasalee.BindingModels.FetchAnything;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Component.Culture;
using Component.Utility.Enums;

namespace BLL.Implementation
{
    public class BOFetch : IBOFetch
    {
        public DataContext _dbContext { get; set; }

        public BOFetch(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Request RequestItem(RequestItemBindingModel model, CultureType culture)
        {

            var Order_Id = Guid.NewGuid().ToString().Substring(0, 6);

            var RequestItem = new Request
            {
               
                Quantity = model.Quantity,

                CreatedAt = DateTime.UtcNow
            };

        
            _dbContext.RequestItem.Add(RequestItem);
            _dbContext.SaveChanges();

            return RequestItem;
            //return _dbContext.RequestItem.Include(x => x.RequestItemML).Include(x => x.RequestItemImages).FirstOrDefault(x => x.Id == RequestItem.Id);
        }

        //public bool SaveRequestImages(RequestItemBindingModel model, int RequestItem_Id)
        //{
        //    if (model.ItemImages != null)
        //    {
        //        foreach (var image in model.ItemImages)
        //        {
        //            _dbContext.RequestItemImages.AddRangeAsync(new RequestItemImages
        //            {
        //                ImageUrl = image.SaveImage("RequestImages"),
        //                RequestItem_Id = RequestItem_Id
        //            });
        //            _dbContext.SaveChanges();
        //        }
        //    }
        //    return true;
        //}

        //public double GetDistance()
        //{
        //    Location loc = new Location(_dbContext);
        //    var store = _dbContext.Store.FirstOrDefault();
        //    loc.Longitude = 55.22;
        //    loc.Latitude = 33.55;
        //    var distance = store.Location.Distance(loc);

        //    //var aa = store.Location.Distance(loc);
        //    return distance;
        //}

        //public List<RequestItem> GetPendingRequests(int User_Id, int Items, int Page, CultureType culture)
        //{
        //    return _dbContext.RequestItem.Include(x => x.RequestItemML).Include(x => x.RequestItemImages).Include(x => x.Driver).Where(x => (x.Status == 1 || x.Status == 1 || x.Status == 1) && x.User_Id == User_Id && x.IsDeleted == false).Skip(Items * Page).Take(Items).OrderByDescending(x => x.Id).ToList();
        //}

        //public List<RequestItem> GetDeliveredOrCompletedRequests(int User_Id, int Items, int Page, CultureType culture)
        //{
        //    return _dbContext.RequestItem.Include(x => x.RequestItemML).Include(x => x.RequestItemImages).Include(x => x.Driver).Where(x => (x.Status == 1 || x.Status == 1 || x.Status == 1) && x.User_Id == User_Id && x.IsDeleted == false).Skip(Items * Page).Take(Items).OrderByDescending(x => x.Id).ToList();
        //}

        //public RequestItem GetRequestById(int Request_Id, CultureType culture)
        //{
        //    return _dbContext.RequestItem.Include(x => x.RequestItemML).Include(x => x.RequestItemImages).Include(x => x.Driver).Include(x => x.DriverRating).Include(x => x.DriverRating.User).Include(x => x.User).FirstOrDefault(x => x.Id == Request_Id);
        //}

        //public double GetDriverRatingOnly(int Driver_Id)
        //{
        //    double AverageRating = 0.0;
        //    var rating = _dbContext.Drivers.Include(x => x.DriverRating).FirstOrDefault(x => x.Id == Driver_Id);
        //    if (rating.DriverRating != null && rating.DriverRating.Count>0)
        //        AverageRating = Convert.ToDouble(rating.DriverRating.Where(x => x.Type == (int)RatingTypes.RateDriver).Average(x => x.Rating).ToString("F2"));

        //    return AverageRating;

        //}


    }
}
