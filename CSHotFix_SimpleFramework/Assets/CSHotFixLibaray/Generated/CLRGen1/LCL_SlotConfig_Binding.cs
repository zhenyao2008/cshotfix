
#if CSHotFix
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

using CSHotFix.CLR.TypeSystem;
using CSHotFix.CLR.Method;
using CSHotFix.Runtime.Enviorment;
using CSHotFix.Runtime.Intepreter;
using CSHotFix.Runtime.Stack;
using CSHotFix.Reflection;
using CSHotFix.CLR.Utils;
using System.Linq;
namespace CSHotFix.Runtime.Generated
{
    unsafe class LCL_SlotConfig_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(LCL.SlotConfig);

            field = type.GetField("m_ListGameObject", flag);
            app.RegisterCLRFieldGetter(field, get_m_ListGameObject_0);
            app.RegisterCLRFieldSetter(field, set_m_ListGameObject_0);


            app.RegisterCLRCreateDefaultInstance(type, () => new LCL.SlotConfig());
            app.RegisterCLRCreateArrayInstance(type, s => new LCL.SlotConfig[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_m_ListGameObject_0(ref object o)
        {
            return ((LCL.SlotConfig)o).m_ListGameObject;
        }
        static void set_m_ListGameObject_0(ref object o, object v)
        {
LCL.SlotConfig _o = (LCL.SlotConfig)o;
    _o.m_ListGameObject = (System.Collections.Generic.List<LCL.KeyGameObject>)v;
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new LCL.SlotConfig();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
