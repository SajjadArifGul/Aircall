﻿<%@ Page Title="" Language="C#" MasterPageFile="~/partner/PartnerMaster.Master" AutoEventWireup="true" CodeBehind="Commission_Report.aspx.cs" Inherits="Aircall.partner.Commission_Report" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="<%=Application["SiteAddress"]%>admin/js/highcharts.js"></script>
    <script src="<%=Application["SiteAddress"]%>admin/js/exporting.js"></script>
    <script src="https://code.highcharts.com/modules/data.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <div class="row-fluid">
            <div class="span12">
                <h3 class="page-title">Commission Report</h3>
                <ul class="breadcrumb">
                    <li><a href="<%=Application["SiteAddress"]%>partner/dashboard.aspx"><i class="icon-home"></i></a><span class="divider">&nbsp;</span></li>
                    <li><a href="#">Commission Report</a><span class="divider-last">&nbsp;</span></li>
                </ul>
            </div>
        </div>
        <div class="row-fluid">
            <div class="span12">
                <div class="widget">
                    <div class="widget-title">
                        <h4><i class="icon-filter"></i>&nbsp;Commission Report Filter</h4>
                        <span class="tools"><a href="javascript:;" class="icon-chevron-down"></a></span>
                    </div>
                    <div class="widget-body">
                        <div class="widget-body form">
                            <div class="form-horizontal">
                                <div class="control-group">
                                    <div class="control-group">
                                        <label class="control-label">
                                            Client&nbsp;<span class="required">*</span>
                                        </label>
                                        <div class="controls input-icon">
                                            <asp:DropDownList ID="ddlClient" runat="server" ClientIDMode="Static">
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                    <div class="control-group">
                                        <label class="control-label">Year<span class="required">*</span></label>
                                        <div class="controls">
                                            <asp:DropDownList ID="ddlYear" runat="server" ClientIDMode="Static">
                                                <asp:ListItem Value="0">select Year</asp:ListItem>
                                            </asp:DropDownList>
                                            <asp:RequiredFieldValidator ID="rqfvYear" runat="server" ErrorMessage="Required" Font-Size="12px" Font-Bold="true" Display="Dynamic" ValidationGroup="ChangeGroup" CssClass="error_required" ControlToValidate="ddlYear" InitialValue="0"></asp:RequiredFieldValidator>
                                        </div>
                                    </div>
                                    <div class="control-group">
                                        <label class="control-label">Month<span class="required">*</span></label>
                                        <div class="controls">
                                            <asp:DropDownList ID="drpMonth" runat="server" ClientIDMode="Static">
                                                <asp:ListItem Value="-1">Select Month</asp:ListItem>
                                                <asp:ListItem Value="0">ALL MONTHS</asp:ListItem>
                                                <asp:ListItem Value="1">JAN</asp:ListItem>
                                                <asp:ListItem Value="2">FEB</asp:ListItem>
                                                <asp:ListItem Value="3">MAR</asp:ListItem>
                                                <asp:ListItem Value="4">APR</asp:ListItem>
                                                <asp:ListItem Value="5">MAY</asp:ListItem>
                                                <asp:ListItem Value="6">JUN</asp:ListItem>
                                                <asp:ListItem Value="7">JULY</asp:ListItem>
                                                <asp:ListItem Value="8">AUG</asp:ListItem>
                                                <asp:ListItem Value="9">SEP</asp:ListItem>
                                                <asp:ListItem Value="10">OCT</asp:ListItem>
                                                <asp:ListItem Value="11">NOV</asp:ListItem>
                                                <asp:ListItem Value="12">DEC</asp:ListItem>
                                            </asp:DropDownList>
                                            <asp:RequiredFieldValidator ID="rqfvMonth" runat="server" ErrorMessage="Required" Font-Size="12px" Font-Bold="true" Display="Dynamic" ValidationGroup="ChangeGroup" CssClass="error_required" ControlToValidate="drpMonth" InitialValue="-1"></asp:RequiredFieldValidator>
                                        </div>
                                    </div>
                                    <div class="form-actions">
                                        <asp:Button ID="btnSubmit" class="btn btn-success" runat="server" ValidationGroup="ChangeGroup" OnClientClick="Comparedates(event); return false;" UseSubmitBehavior="false" Text="Search" />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="row-fluid">
            <div class="span12" style="overflow: scroll;">
                <div class="widget">
                    <div class="widget-title">
                        <h4><i class="icon-bar-chart"></i>&nbsp;Commission Report</h4>
                    </div>
                    <div class="widget-body">
                        <div id="site_statistics_loading">
                            <img src="<%=Application["SiteAddress"]%>partner/img/loading.gif" alt="loading" />
                        </div>
                        <div id="site_statistics_content" class="hide">
                            <div id="commission_report" class="chart"></div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <script>
        jQuery(document).ready(function () {
            App.setMainPage(true); App.init();
            atpageload();
        });
        function atpageload() {
            var strmonth = "<%= strcurrentmonth %>";
            var stryear = "<%= strcurrentYear %>";
            $('#drpMonth').val("<%= strcurrentmonth %>");
            $('#ddlYear').val("<%= strcurrentYear %>");
            BindClientData(strmonth, stryear);
        }
        function Comparedates(e) {
            if (Page_ClientValidate()) {
                var stryear = $('#ddlYear option:selected').val();
                var strmonth = $('#drpMonth option:selected').val();
                BindClientData(strmonth, stryear);
            }
            e.preventDefault();
            return false;
        }
        function BindClientData(strmonth, stryear) {
            $.ajax({
                type: "POST",
                url: "Commission_Report.aspx/BindChart",
                data: "{'ClientId':'" + $('#ddlClient option:selected').val() + "','strmonth':'" + strmonth + "','stryear':'" + stryear + "'}",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: OnSuccessSchedule,
                failure: function (response) {
                    alert(response.d);
                }
            });
        }
        function OnSuccessSchedule(response) {
            var pageviews = [[, ]];
            var rowcount = response.d.split('##').length;
            var minvalue = 0, maxvalue = 0;
            for (var i = 0; i < rowcount; i++) {
                var Arr = response.d.split('##');
                var FillVal = Arr[i].split('|');
                val1 = FillVal[0];
                val2 = FillVal[1];
                pageviews[i] = [val1, parseFloat(val2)];
                //pageviews.push([val1, parseFloat(val2)]);
                if (val2 > maxvalue)
                    maxvalue = parseFloat(val2);
                if (val2 < minvalue)
                    minvalue = parseFloat(val2);
            }
            $('#site_statistics_loading').hide();
            $('#site_statistics_content').show();
            maxvalue = (maxvalue > 0 ? maxvalue + 100 : 1);
            BindBarChart(pageviews, maxvalue);
        }

        function BindBarChart(pageviews, maxvalue) {
            $('#commission_report').highcharts({
                title: {
                    text: ''
                },
                subtitle: {
                    text: ''
                },
                xAxis: {
                    type: 'category',
                    labels: {
                        rotation: -45,
                        style: {
                            fontSize: '13px',
                            fontFamily: 'Verdana, sans-serif'
                        }
                    }
                },
                yAxis: {
                    min: 0,
                    max: maxvalue,
                    title: {
                        text: 'Monthly Sales ($)'
                    }
                },
                legend: {
                    enabled: false
                },
                tooltip: {
                    formatter: function () {
                        var month = new Array();
                        month[1] = "JAN";
                        month[2] = "FEB";
                        month[3] = "MARCH";
                        month[4] = "APR";
                        month[5] = "MAY";
                        month[6] = "JUN";
                        month[7] = "JULY";
                        month[8] = "AUG";
                        month[9] = "SEP";
                        month[10] = "OCT";
                        month[11] = "NOV";
                        month[12] = "DEC";
                        var monthname;
                        monthname = month[this.x];
                        if ($('#drpMonth option:selected').val() != "0") {
                            monthname = month[$('#drpMonth option:selected').val()];
                            var d1 = parseInt(this.x) + 1;
                            return "Order on <b>" + $('#drpMonth option:selected').val() + "/" + d1 + "/" + $('#ddlYear option:selected').val() + " = $ " + Highcharts.numberFormat(this.y, 2, '.', ',') + "</b>";
                        } else {
                            monthname = month[this.x];
                            //return 'Order on <%= strcurrentmonth %>/' + this.x + '/<%= strcurrentYear %> = $ ' + Highcharts.numberFormat(this.y, 2) + '';
                            return 'Order on <b>' + monthname + ' /<%= strcurrentYear %> = $ ' + Highcharts.numberFormat(this.y, 2, '.', ',') + '</b>';
                        }

                    }
                },
                series: [{
                    name: 'Population',
                    data: pageviews,
                    dataLabels: {
                        enabled: false,
                        rotation: -90,
                        color: '#FFFFFF',
                        align: 'right',
                        //format: '{point.y:.1f}', // one decimal
                        format: '{point.y:.2f}',
                        y: 5, // 10 pixels down from the top
                        style: {
                            fontSize: '13px',
                            fontFamily: 'Verdana, sans-serif'
                        }
                    }
                }]
            });
        }
    </script>
</asp:Content>
