﻿/***********************************************
 * CONFIDENTIAL AND PROPRIETARY 
 * 
 * The source code and other information contained herein is the confidential and exclusive property of
 * ZIH Corp. and is subject to the terms and conditions in your end user license agreement.
 * This source code, and any other information contained herein, shall not be copied, reproduced, published, 
 * displayed or distributed, in whole or in part, in any medium, by any means, for any purpose except as
 * expressly permitted under such license agreement.
 * 
 * Copyright ZIH Corp. 2018
 * 
 * ALL RIGHTS RESERVED
 ***********************************************/

using System.Collections.ObjectModel;
using Zebra.Sdk.Printer.Discovery;

namespace DeveloperDemo_Card_Desktop.Discovery {

    public class PrinterDiscoveryDialogViewModel : ViewModelBase {

        private bool isDiscovering = false;
        private DiscoveredPrinter selectedPrinter;
        private ObservableCollection<DiscoveredPrinter> discoveredPrinters = new ObservableCollection<DiscoveredPrinter>();

        public bool IsDiscovering {
            get => isDiscovering;
            set {
                isDiscovering = value;
                OnPropertyChanged();
            }
        }

        public DiscoveredPrinter SelectedPrinter {
            get => selectedPrinter;
            set {
                selectedPrinter = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<DiscoveredPrinter> DiscoveredPrinters {
            get => discoveredPrinters;
        }
    }
}
