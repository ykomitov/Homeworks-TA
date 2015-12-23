﻿/*
* Kendo UI v2015.3.1111 (http://www.telerik.com/kendo-ui)
* Copyright 2015 Telerik AD. All rights reserved.
*
* Kendo UI commercial licenses may be obtained at
* http://www.telerik.com/purchase/license-agreement/kendo-ui-complete
* If you do not own a commercial license, this file shall be governed by the trial license terms.
*/
!function (e, define) { define(["./kendo.calendar.min", "./kendo.popup.min"], e) }(function () { return function (e, t) { function n(t) { var n = t.parseFormats, i = t.format; L.normalize(t), n = e.isArray(n) ? n : [n], n.length || n.push("yyyy-MM-dd"), -1 === e.inArray(i, n) && n.splice(0, 0, t.format), t.parseFormats = n } function i(e) { e.preventDefault() } var o, r = window.kendo, s = r.ui, a = s.Widget, l = r.parseDate, c = r.keys, h = r.template, u = r._activeElement, d = "<div />", f = "<span />", p = ".kendoDatePicker", g = "click" + p, m = "open", v = "close", _ = "change", w = "disabled", y = "readonly", b = "k-state-default", x = "k-state-focused", k = "k-state-selected", C = "k-state-disabled", S = "k-state-hover", T = "mouseenter" + p + " mouseleave" + p, A = "mousedown" + p, D = "id", M = "min", P = "max", E = "month", I = "aria-disabled", B = "aria-expanded", R = "aria-hidden", z = "aria-readonly", L = r.calendar, F = L.isInRange, O = L.restrictValue, N = L.isEqualDatePart, V = e.extend, H = e.proxy, U = Date, j = function (t) { var n, i = this, o = document.body, a = e(d).attr(R, "true").addClass("k-calendar-container").appendTo(o); i.options = t = t || {}, n = t.id, n && (n += "_dateview", a.attr(D, n), i._dateViewID = n), i.popup = new s.Popup(a, V(t.popup, t, { name: "Popup", isRtl: r.support.isRtl(t.anchor) })), i.div = a, i.value(t.value) }; j.prototype = { _calendar: function () { var t, n = this, o = n.calendar, a = n.options; o || (t = e(d).attr(D, r.guid()).appendTo(n.popup.element).on(A, i).on(g, "td:has(.k-link)", H(n._click, n)), n.calendar = o = new s.Calendar(t), n._setOptions(a), r.calendar.makeUnselectable(o.element), o.navigate(n._value || n._current, a.start), n.value(n._value)) }, _setOptions: function (e) { this.calendar.setOptions({ focusOnNav: !1, change: e.change, culture: e.culture, dates: e.dates, depth: e.depth, footer: e.footer, format: e.format, max: e.max, min: e.min, month: e.month, start: e.start }) }, setOptions: function (e) { var t = this.options; this.options = V(t, e, { change: t.change, close: t.close, open: t.open }), this.calendar && this._setOptions(this.options) }, destroy: function () { this.popup.destroy() }, open: function () { var e = this; e._calendar(), e.popup.open() }, close: function () { this.popup.close() }, min: function (e) { this._option(M, e) }, max: function (e) { this._option(P, e) }, toggle: function () { var e = this; e[e.popup.visible() ? v : m]() }, move: function (e) { var t = this, n = e.keyCode, i = t.calendar, o = e.ctrlKey && n == c.DOWN || n == c.ENTER, r = !1; if (e.altKey) n == c.DOWN ? (t.open(), e.preventDefault(), r = !0) : n == c.UP && (t.close(), e.preventDefault(), r = !0); else if (t.popup.visible()) { if (n == c.ESC || o && i._cell.hasClass(k)) return t.close(), e.preventDefault(), !0; t._current = i._move(e), r = !0 } return r }, current: function (e) { this._current = e, this.calendar._focus(e) }, value: function (e) { var t = this, n = t.calendar, i = t.options; t._value = e, t._current = new U(+O(e, i.min, i.max)), n && n.value(e) }, _click: function (e) { -1 !== e.currentTarget.className.indexOf(k) && this.close() }, _option: function (e, t) { var n = this, i = n.calendar; n.options[e] = t, i && i[e](t) } }, j.normalize = n, r.DateView = j, o = a.extend({ init: function (t, i) { var o, s, c = this; a.fn.init.call(c, t, i), t = c.element, i = c.options, i.min = l(t.attr("min")) || l(i.min), i.max = l(t.attr("max")) || l(i.max), n(i), c._initialOptions = V({}, i), c._wrapper(), c.dateView = new j(V({}, i, { id: t.attr(D), anchor: c.wrapper, change: function () { c._change(this.value()), c.close() }, close: function (e) { c.trigger(v) ? e.preventDefault() : (t.attr(B, !1), s.attr(R, !0)) }, open: function (e) { var n, i = c.options; c.trigger(m) ? e.preventDefault() : (c.element.val() !== c._oldText && (n = l(t.val(), i.parseFormats, i.culture), c.dateView[n ? "current" : "value"](n)), t.attr(B, !0), s.attr(R, !1), c._updateARIA(n)) } })), s = c.dateView.div, c._icon(); try { t[0].setAttribute("type", "text") } catch (h) { t[0].type = "text" } t.addClass("k-input").attr({ role: "combobox", "aria-expanded": !1, "aria-owns": c.dateView._dateViewID }), c._reset(), c._template(), o = t.is("[disabled]") || e(c.element).parents("fieldset").is(":disabled"), o ? c.enable(!1) : c.readonly(t.is("[readonly]")), c._old = c._update(i.value || c.element.val()), c._oldText = t.val(), r.notify(c) }, events: [m, v, _], options: { name: "DatePicker", value: null, footer: "", format: "", culture: "", parseFormats: [], min: new Date(1900, 0, 1), max: new Date(2099, 11, 31), start: E, depth: E, animation: {}, month: {}, dates: [], ARIATemplate: 'Current focused date is #=kendo.toString(data.current, "D")#' }, setOptions: function (e) { var t = this, i = t._value; a.fn.setOptions.call(t, e), e = t.options, e.min = l(e.min), e.max = l(e.max), n(e), t.dateView.setOptions(e), i && (t.element.val(r.toString(i, e.format, e.culture)), t._updateARIA(i)) }, _editable: function (e) { var t = this, n = t._dateIcon.off(p), o = t.element.off(p), r = t._inputWrapper.off(p), s = e.readonly, a = e.disable; s || a ? (r.addClass(a ? C : b).removeClass(a ? b : C), o.attr(w, a).attr(y, s).attr(I, a).attr(z, s)) : (r.addClass(b).removeClass(C).on(T, t._toggleHover), o.removeAttr(w).removeAttr(y).attr(I, !1).attr(z, !1).on("keydown" + p, H(t._keydown, t)).on("focusout" + p, H(t._blur, t)).on("focus" + p, function () { t._inputWrapper.addClass(x) }), n.on(g, H(t._click, t)).on(A, i)) }, readonly: function (e) { this._editable({ readonly: e === t ? !0 : e, disable: !1 }) }, enable: function (e) { this._editable({ readonly: !1, disable: !(e = e === t ? !0 : e) }) }, destroy: function () { var e = this; a.fn.destroy.call(e), e.dateView.destroy(), e.element.off(p), e._dateIcon.off(p), e._inputWrapper.off(p), e._form && e._form.off("reset", e._resetHandler) }, open: function () { this.dateView.open() }, close: function () { this.dateView.close() }, min: function (e) { return this._option(M, e) }, max: function (e) { return this._option(P, e) }, value: function (e) { var n = this; return e === t ? n._value : (n._old = n._update(e), null === n._old && n.element.val(""), n._oldText = n.element.val(), t) }, _toggleHover: function (t) { e(t.currentTarget).toggleClass(S, "mouseenter" === t.type) }, _blur: function () { var e = this, t = e.element.val(); e.close(), t !== e._oldText && e._change(t), e._inputWrapper.removeClass(x) }, _click: function () { var e = this, t = e.element; e.dateView.toggle(), r.support.touch || t[0] === u() || t.focus() }, _change: function (e) { var t = this; e = t._update(e), +t._old != +e && (t._old = e, t._oldText = t.element.val(), t._typing || t.element.trigger(_), t.trigger(_)), t._typing = !1 }, _keydown: function (e) { var t = this, n = t.dateView, i = t.element.val(), o = !1; n.popup.visible() || e.keyCode != c.ENTER || i === t._oldText ? (o = n.move(e), t._updateARIA(n._current), o || (t._typing = !0)) : t._change(i) }, _icon: function () { var t, n = this, i = n.element; t = i.next("span.k-select"), t[0] || (t = e('<span unselectable="on" class="k-select"><span unselectable="on" class="k-icon k-i-calendar">select</span></span>').insertAfter(i)), n._dateIcon = t.attr({ role: "button", "aria-controls": n.dateView._dateViewID }) }, _option: function (e, n) { var i = this, o = i.options; return n === t ? o[e] : (n = l(n, o.parseFormats, o.culture), n && (o[e] = new U(+n), i.dateView[e](n)), t) }, _update: function (e) { var t, n = this, i = n.options, o = i.min, s = i.max, a = n._value, c = l(e, i.parseFormats, i.culture), h = null === c && null === a || c instanceof Date && a instanceof Date; return +c === +a && h ? (t = r.toString(c, i.format, i.culture), t !== e && n.element.val(null === c ? e : t), c) : (null !== c && N(c, o) ? c = O(c, o, s) : F(c, o, s) || (c = null), n._value = c, n.dateView.value(c), n.element.val(c ? r.toString(c, i.format, i.culture) : e), n._updateARIA(c), c) }, _wrapper: function () { var t, n = this, i = n.element; t = i.parents(".k-datepicker"), t[0] || (t = i.wrap(f).parent().addClass("k-picker-wrap k-state-default"), t = t.wrap(f).parent()), t[0].style.cssText = i[0].style.cssText, i.css({ width: "100%", height: i[0].style.height }), n.wrapper = t.addClass("k-widget k-datepicker k-header").addClass(i[0].className), n._inputWrapper = e(t[0].firstChild) }, _reset: function () { var t = this, n = t.element, i = n.attr("form"), o = i ? e("#" + i) : n.closest("form"); o[0] && (t._resetHandler = function () { t.value(n[0].defaultValue), t.max(t._initialOptions.max), t.min(t._initialOptions.min) }, t._form = o.on("reset", t._resetHandler)) }, _template: function () { this._ariaTemplate = h(this.options.ARIATemplate) }, _updateARIA: function (e) { var t, n = this, i = n.dateView.calendar; n.element.removeAttr("aria-activedescendant"), i && (t = i._cell, t.attr("aria-label", n._ariaTemplate({ current: e || i.current() })), n.element.attr("aria-activedescendant", t.attr("id"))) } }), s.plugin(o) }(window.kendo.jQuery), window.kendo }, "function" == typeof define && define.amd ? define : function (e, t) { t() });