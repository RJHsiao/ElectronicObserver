﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicObserver.Resource.SaveData {

	public sealed class SaveDataMaster {

		#region Singleton

		private static readonly SaveDataMaster instance = new SaveDataMaster();

		public static SaveDataMaster Instance {
			get { return instance; }
		}

		#endregion

		public string SaveFolderName { get; private set; } 
		public EnemyFleetData EnemyFleet;


		private SaveDataMaster() {

			SaveFolderName = @"Settings\";
			EnemyFleet = new EnemyFleetData();

			if ( !Directory.Exists( SaveFolderName ) ) {
				Directory.CreateDirectory( SaveFolderName );
			}
		}



		public void Load() {

			EnemyFleet.Load( SaveFolderName );

		}

		public void Save() {

			EnemyFleet.Save( SaveFolderName );

		}

	}

}