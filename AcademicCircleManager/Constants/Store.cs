using Newtonsoft.Json;
using AcademicCircleManagerApp.Model;
using AcademicCircleManagerApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;

namespace AcademicCircleManagerApp.Constants
{
    static class Store
    {
        public static string DataDirectory;
        public static string UserDataDir;
        public static string SavedFacultysDir;
        public static string SavedMembersDir;

        private static ObservableCollection<Member> _members;
        private static List<Faculty> _facultys;
        private static int[] _yearOptions;
        private static int _yearRange = 10;

        public static int[] YearOptions
        {
            get
            {
                if (_yearOptions is null)
                {
                    _yearOptions = new int[_yearRange];
                    for (int i = 0; i < _yearRange;)
                    {
                        _yearOptions[i] = ++i;
                    }
                }
                return _yearOptions;
            }
        }
        public static AttributeFormVM OpenAttributearyForm;

        public static List<Faculty> Facultys
        {
            get
            {
                if (_facultys is null)
                    LoadFacultys();
                return _facultys;
            }
        }
        public static ObservableCollection<Member> Members
        {
            get
            {
                if (_members is null)
                {
                    LoadMembers();
                }
                return _members;
            }
        }
        public static Manager User { get; set; }

        static Store()
        {
            DataDirectory = Environment.GetEnvironmentVariable("appdata") + "\\AcademicCircleManager";
            UserDataDir = DataDirectory + "\\user.json";
            SavedFacultysDir = DataDirectory + "\\facultys.json";
            SavedMembersDir = DataDirectory + "\\members.json";
        }

        public static void SaveMembers()
        {
            var members = new List<Member>();
            foreach (var patient in _members)
                members.Add(patient);

            string SaveJson = JsonConvert.SerializeObject(members);
            File.WriteAllText(SavedMembersDir, SaveJson);
        }

        public static void LoadMembers()
        {
            _members = new ObservableCollection<Member>();

            if (File.Exists(SavedMembersDir))
            {
                List<Member> load = JsonConvert.DeserializeObject<List<Member>>(File.ReadAllText(SavedMembersDir));

                if (load != null)
                    foreach (var patient in load)
                        _members.Add(patient);
            }

        }

        public static void LoadFacultys()
        {
            _facultys = new List<Faculty>();

            if (File.Exists(SavedFacultysDir))
            {
                var loadedFacultys = JsonConvert.DeserializeObject<List<Faculty>>(File.ReadAllText(SavedFacultysDir));
                if (loadedFacultys != null)
                {
                    foreach (var school in loadedFacultys)
                        _facultys.Add(school);
                }
            }
        }

        public static void SaveFacultys()
        {
            string SaveJson = JsonConvert.SerializeObject(_facultys);
            File.WriteAllText(SavedFacultysDir, SaveJson);
        }

        public static bool TryLoadUserData()
        {
            if (!File.Exists(UserDataDir)) return false;

            User = JsonConvert.DeserializeObject<Manager>(File.ReadAllText(UserDataDir));
            return true;
        }

        public static void SaveUserData()
        {
            if (!Directory.Exists(DataDirectory)) Directory.CreateDirectory(DataDirectory);
            string rawJson = JsonConvert.SerializeObject(User);
            File.WriteAllText(UserDataDir, rawJson);
        }
    }
}
