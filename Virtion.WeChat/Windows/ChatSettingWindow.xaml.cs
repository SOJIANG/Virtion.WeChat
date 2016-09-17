﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Virtion.WeChat.Struct;

namespace Virtion.WeChat.Windows
{

    public partial class ChatSettingWindow : Window
    {
        public bool IsFilterMsg
        {
            get
            {
                return this.CB_IsFilterMsg.IsChecked.Value;
            }
            set
            {
                this.CB_IsFilterMsg.IsChecked = value;
            }
        }
        public string MaxMsgLength
        {
            get
            {
                return this.TB_MaxMsgLength.Text;
            }
            set
            {
                this.TB_MaxMsgLength.Text = value;
            }
        }
        public bool IsFilterAdd
        {
            get
            {
                return this.CB_IsFilterAdd.IsChecked.Value;
            }
            set
            {
                this.CB_IsFilterAdd.IsChecked = value;
            }
        }
        public bool IsFilterSelf
        {
            get
            {
                return this.CB_IsFilterSelf.IsChecked.Value;
            }
            set
            {
                this.CB_IsFilterSelf.IsChecked = value;
            }
        }
        public bool IsHightLight
        {
            get
            {
                return this.CB_IsHightLight.IsChecked.Value;
            }
            set
            {
                this.CB_IsHightLight.IsChecked = value;
            }
        }

        private ChatConfig config;

        public ChatSettingWindow()
        {
            InitializeComponent();
        }

        public void SetConfig(ChatConfig config)
        {
            this.config = config;

            IsFilterMsg = config.IsFilterMsg;
            MaxMsgLength = config.MaxMsgLength.ToString();
            IsFilterAdd = config.IsFilterAdd;
            IsFilterSelf = config.IsFilterSelf;
            IsHightLight = config.IsHightLight;
        }

        public ChatConfig GetConfig()
        {
            this.config.IsFilterMsg = this.CB_IsFilterMsg.IsChecked.Value;
            this.config.IsFilterSelf = this.CB_IsFilterSelf.IsChecked.Value;
            this.config.IsHightLight = this.CB_IsFilterAdd.IsChecked.Value;
            this.config.IsFilterAdd = this.CB_IsFilterAdd.IsChecked.Value;
            int i = 0;
            if (Int32.TryParse(this.TB_MaxMsgLength.Text, out i) == true)
            {
                this.config.MaxMsgLength = i;
            }
            else
            {
                MessageBox.Show("输入不是数字");
            }
            return this.config;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


    }
}