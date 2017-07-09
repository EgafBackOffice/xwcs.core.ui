﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xwcs.core.ui.cnt
{
    public interface IContent : IDisposable
    {
		void Load(string Path);

		System.Windows.Forms.DockStyle Dock { get; set; }
	}
}
