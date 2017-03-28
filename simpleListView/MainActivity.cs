using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using simpleListView;

namespace simpleListView
{
    [Activity(Label = "simpleListView", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private List<string> mItems;
        private ListView mListVew;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);
            mListVew = FindViewById<ListView>(Resource.Id.ListView1);
            
            mItems = new List<string>();
            mItems.Add("Abhishek");
            mItems.Add("RAVI");
            mItems.Add("sujeeth");
            mItems.Add("rakesh");
            mItems.Add("rakesh");
            mItems.Add("rakesh");
            mItems.Add("rakesh");
            mItems.Add("rakesh");
            mItems.Add("rakesh");

            mItems.Add("rakesh");
            mItems.Add("rakesh");

            MyListVewAdopter adapter = new MyListVewAdopter(this, mItems);
            mListVew.Adapter = adapter;

            







        }
    }
}

