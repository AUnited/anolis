﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Xml;
using System.Diagnostics;

using Microsoft.Win32;

using P = System.IO.Path;


namespace Anolis.Core.Packages.Operations {
	
	public class CursorSchemeOperation : Operation {
		
		private List<CursorScheme> _schemes;
		
		public CursorSchemeOperation(Package package, XmlElement element) :  base(package, element) {
			
			_schemes = new List<CursorScheme>();
			
			CursorScheme scheme = new CursorScheme(package, element );
			
			_schemes.Add( scheme );
		}
		
		protected override String OperationName {
			get { return "Cursor scheme"; }
		}
		
		public override Boolean Merge(Operation operation) {
			
			CursorSchemeOperation other = operation as CursorSchemeOperation;
			if(other == null) return false;
			
			_schemes.AddRange( other._schemes );
			
			return true;
		}
		
		public override void Execute() {
			
			for(int i=0;i<_schemes.Count;i++) {
				
				CursorScheme scheme = _schemes[i];
				
				scheme.Install();
				scheme.Register();
				
				if(i == _schemes.Count - 1)
					scheme.MakeActive();
				
			}
			
		}
		
		private class CursorScheme {
			
			public String        SchemeName;
			public CursorEntry[] Cursors = new CursorEntry[15];
			
			public CursorScheme(Package package, XmlElement element) {
				
				this.SchemeName = element.GetAttribute("schemeName");
				
				foreach(XmlNode node in element.ChildNodes) {
					
					if(node.NodeType != XmlNodeType.Element) continue;
					
					XmlElement child = node as XmlElement;
					
					//////////////////////////////////////////////////
					
					CursorType type = (CursorType)Enum.Parse(typeof(CursorType), child.GetAttribute("type") );
					String     path = PackageUtility.ResolvePath( child.GetAttribute("src"), package.RootDirectory.FullName);
					
					int idx = (int)type;
					
					this.Cursors[ idx ] = new CursorEntry() { CursorType = type, CursorFilename = path };
				}
				
				
			}
			
			public void Install() {
				
				// initially the CursorFilename refer to the local path
				// this method copies the files over to the Cursors directory and updates the Filenames
				
				String cursorsDirPath = PackageUtility.ResolvePath(@"%windir%\Cursors");
				
				DirectoryInfo cursorsDir = new DirectoryInfo( cursorsDirPath );
				DirectoryInfo schemeDir  = cursorsDir.CreateSubdirectory( SchemeName );
				
				foreach(CursorEntry cursor in Cursors) {
					if(cursor == null) continue;
					
					String src  = cursor.CursorFilename;
					
					String dest = P.Combine( schemeDir.FullName, P.GetFileName( cursor.CursorFilename ) );
					
					File.Copy( src, dest );
					
					cursor.CursorFilename = dest;
				}
				
			}
			
			public void Register() {
				// registers this scheme in the currentuser reg hive
				
				RegistryKey schemesKey = Registry.CurrentUser.CreateSubKey(@"Control Panel\Cursors\Schemes");
				schemesKey.SetValue( SchemeName, CreateLine(), RegistryValueKind.String );
				schemesKey.Close();
				
			}
			
			private String CreateLine() {
				
				StringBuilder sb = new StringBuilder();
				
				for(int i=0;i<Cursors.Length;i++) {
					
					CursorEntry cursor = Cursors[i];
					if(cursor != null) sb.Append( P.GetFileName( cursor.CursorFilename ) );
					
					if( i != Cursors.Length - 1 ) sb.Append(',');
					
				}
				
				return sb.ToString();
			}
			
			public void MakeActive() {
				
				RegistryKey activeCursorsKey = Registry.CurrentUser.OpenSubKey(@"Control Panel\Cursors", true);
				activeCursorsKey.SetValue(null, SchemeName, RegistryValueKind.String);
				activeCursorsKey.SetValue("Scheme Source", 1, RegistryValueKind.DWord); // 0 = Windows Default, 1 = User Scheme, 2 = System Scheme
				
				foreach(CursorEntry cursor in Cursors) {
					
					if(cursor == null) continue;
					
					String valName = cursor.CursorType.ToString();
					String valValu = cursor.CursorFilename;
					
					activeCursorsKey.SetValue(valName, valValu, RegistryValueKind.String);
				}
				
				activeCursorsKey.Close();
				
			}
			
			
		}
		
		private class CursorEntry {
			public CursorType CursorType;
			public String     CursorFilename;
		}
		
		public enum CursorType {
			Arrow       = 1,
			Help        = 2,
			AppStarting = 3,
			Wait        = 4,
			Crosshair   = 5,
			IBeam       = 6,
			NWPen       = 7,
			No          = 8,
			SizeNS      = 9,
			SizeWE      = 10,
			SizeNWSE    = 11,
			SizeNESW    = 12,
			SizeAll     = 13,
			UpArrow     = 14,
			Hand        = 15
		}
		
	}
	
	
	public class FileTypeOperation : Operation {
		
		public FileTypeOperation(Package package, XmlElement element) :  base(package, element) {
		}
		
		protected override string OperationName {
			get { throw new NotImplementedException(); }
		}

		public override void Execute() {
			throw new NotImplementedException();
		}

		public override bool Merge(Operation operation) {
			throw new NotImplementedException();
		}
	}
	
	public class RegistryOperation : Operation {
		
		public RegistryOperation(Package package, XmlElement element) :  base(package, element) {
		}
		
		protected override string OperationName {
			get { throw new NotImplementedException(); }
		}

		public override void Execute() {
			throw new NotImplementedException();
		}

		public override bool Merge(Operation operation) {
			throw new NotImplementedException();
		}
	}
	
}