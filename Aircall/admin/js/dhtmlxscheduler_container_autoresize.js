﻿/*
dhtmlxScheduler v.4.2.0 Stardard

This software is covered by GPL license. You also can obtain Commercial or Enterprise license to use it in non-GPL project - please contact sales@dhtmlx.com. Usage without proper license is prohibited.

(c) Dinamenta, UAB.
*/
!function () {
    scheduler.config.container_autoresize = !0, scheduler.config.month_day_min_height = 90; var e = scheduler._pre_render_events; scheduler._pre_render_events = function (t, i) {
        if (!scheduler.config.container_autoresize) return e.apply(this, arguments); var s = this.xy.bar_height, a = this._colsS.heights, n = this._colsS.heights = [0, 0, 0, 0, 0, 0, 0], r = this._els.dhx_cal_data[0]; if (t = this._table_view ? this._pre_render_events_table(t, i) : this._pre_render_events_line(t, i), this._table_view) if (i) this._colsS.heights = a; else {
            var d = r.firstChild;
            if (d.rows) {
                for (var l = 0; l < d.rows.length; l++) {
                    if (n[l]++, n[l] * s > this._colsS.height - this.xy.month_head_height) {
                        var o = d.rows[l].cells, h = this._colsS.height - this.xy.month_head_height; 1 * this.config.max_month_events !== this.config.max_month_events || n[l] <= this.config.max_month_events ? h = n[l] * s : (this.config.max_month_events + 1) * s > this._colsS.height - this.xy.month_head_height && (h = (this.config.max_month_events + 1) * s); for (var _ = 0; _ < o.length; _++) o[_].childNodes[1].style.height = h + "px"; n[l] = (n[l - 1] || 0) + o[0].offsetHeight
                    } n[l] = (n[l - 1] || 0) + d.rows[l].cells[0].offsetHeight
                } n.unshift(0), d.parentNode.offsetHeight < d.parentNode.scrollHeight && !d._h_fix
            } else if (t.length || "visible" != this._els.dhx_multi_day[0].style.visibility || (n[0] = -1), t.length || -1 == n[0]) {
                var c = (d.parentNode.childNodes, (n[0] + 1) * s + 1 + "px"); r.style.top = this._els.dhx_cal_navline[0].offsetHeight + this._els.dhx_cal_header[0].offsetHeight + parseInt(c, 10) + "px", r.style.height = this._obj.offsetHeight - parseInt(r.style.top, 10) - (this.xy.margin_top || 0) + "px"; var u = this._els.dhx_multi_day[0];
                u.style.height = c, u.style.visibility = -1 == n[0] ? "hidden" : "visible", u = this._els.dhx_multi_day[1], u.style.height = c, u.style.visibility = -1 == n[0] ? "hidden" : "visible", u.className = n[0] ? "dhx_multi_day_icon" : "dhx_multi_day_icon_small", this._dy_shift = (n[0] + 1) * s, n[0] = 0
            }
        } return t
    }; var t = ["dhx_cal_navline", "dhx_cal_header", "dhx_multi_day", "dhx_cal_data"], i = function (e) {
        for (var i = 0, s = 0; s < t.length; s++) {
            var a = t[s], n = scheduler._els[a] ? scheduler._els[a][0] : null, r = 0; switch (a) {
                case "dhx_cal_navline": case "dhx_cal_header": r = parseInt(n.style.height, 10);
                    break; case "dhx_multi_day": r = n ? n.offsetHeight : 0, 1 == r && (r = 0); break; case "dhx_cal_data": r = Math.max(n.offsetHeight - 1, n.scrollHeight); var d = scheduler.getState().mode; if ("month" == d) { if (scheduler.config.month_day_min_height && !e) { var l = n.getElementsByTagName("tr").length; r = l * scheduler.config.month_day_min_height } e && (n.style.height = r + "px") } if (scheduler.matrix && scheduler.matrix[d]) if (e) r += 2, n.style.height = r + "px"; else {
                        r = 2; for (var o = scheduler.matrix[d], h = o.y_unit, _ = 0; _ < h.length; _++) r += h[_].children ? o.folder_dy || o.dy : o.dy
                    } ("day" == d || "week" == d) && (r += 2)
            } i += r
        } scheduler._obj.style.height = i + "px", e || scheduler.updateView()
    }, s = function () { var e = scheduler.getState().mode; i(), (scheduler.matrix && scheduler.matrix[e] || "month" == e) && window.setTimeout(function () { i(!0) }, 1) }; scheduler.attachEvent("onViewChange", s), scheduler.attachEvent("onXLE", s), scheduler.attachEvent("onEventChanged", s), scheduler.attachEvent("onEventCreated", s), scheduler.attachEvent("onEventAdded", s), scheduler.attachEvent("onEventDeleted", s), scheduler.attachEvent("onAfterSchedulerResize", s), scheduler.attachEvent("onClearAll", s)
}();
//# sourceMappingURL=../sources/ext/dhtmlxscheduler_container_autoresize.js.map