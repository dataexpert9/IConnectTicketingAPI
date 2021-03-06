﻿using Component.Models;
using Component.Models.Driver;
using Component.Utility.Enums;
using DAL;
using System.Collections.Generic;

namespace BLL.Interface
{
    public interface IBODriver
    {
        //Driver InsertDriver(RegisterDriverBindingModel driver,CultureType culture);
        bool Exists(string email);
        //Driver AuthenticateCredentials(string username, string password);
        List<Request> GetAllRequests(int Items,int Page);
        List<Request> GetRiderRequests(int Driver_Id, int Items, int Page);
        bool CancelBooking(int Driver_Id, int Request_Id);
        Request AcceptRequest(int Driver_Id, int Request_Id);
        //Driver UpdateAvailabilityStatus(int Driver_Id, bool IsAvailable);
        bool UpdateNotificationStatus(int Driver_Id,bool IsNotificationOn);
        bool ChangeDriverPassword(int Driver_Id,string Password,string NewPassword);
        //Driver GetDriverProfile(int Driver_Id);
        //DriverRating RateDriver(RateDriverBindingModel model, CultureType culture);
        //Driver GetDriverDetailsById(int Driver_Id, CultureType culture);
        bool ReportProblem(ReportProblemBindingModel model);
        //List<DriverRating> GetDriverRatings(int Driver_Id, int? Items = 3, int? Page = 0);
        bool EndRide(int Driver_Id, int Request_Id);
        //Driver StartRide(int Driver_Id, int Request_Id);
        //double DriverAverageRating(int Id);

        //List<DriverRating> GetDriverRatings(int Driver_Id, int? Items = 3, int? Page = 0);
        int GetTotalRatingsOfDriver(int Driver_Id);

        //DriverRating GiveFeedbackToDriver(FeedbackToDriverBindingModel model, CultureType culture);
    }
}
