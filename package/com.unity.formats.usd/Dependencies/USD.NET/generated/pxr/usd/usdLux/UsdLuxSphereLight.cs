//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace pxr
{
    public class UsdLuxSphereLight : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal UsdLuxSphereLight(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdLuxSphereLight obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~UsdLuxSphereLight()
        {
            Dispose();
        }

        public virtual void Dispose()
        {
            lock (this) {
                if (swigCPtr.Handle != global::System.IntPtr.Zero)
                {
                    if (swigCMemOwn)
                    {
                        swigCMemOwn = false;
                        UsdCsPINVOKE.delete_UsdLuxSphereLight(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
            }
        }

        public UsdLuxSphereLight(UsdPrim prim) : this(UsdCsPINVOKE.new_UsdLuxSphereLight__SWIG_0(UsdPrim.getCPtr(prim)), true)
        {
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public UsdLuxSphereLight() : this(UsdCsPINVOKE.new_UsdLuxSphereLight__SWIG_1(), true)
        {
        }

        public UsdLuxSphereLight(UsdSchemaBase schemaObj) : this(UsdCsPINVOKE.new_UsdLuxSphereLight__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), true)
        {
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
        {
            TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.UsdLuxSphereLight_GetSchemaAttributeNames__SWIG_0(includeInherited), false);
            return ret;
        }

        public static TfTokenVector GetSchemaAttributeNames()
        {
            TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.UsdLuxSphereLight_GetSchemaAttributeNames__SWIG_1(), false);
            return ret;
        }

        public static UsdLuxSphereLight Get(UsdStageWeakPtr stage, SdfPath path)
        {
            UsdLuxSphereLight ret = new UsdLuxSphereLight(UsdCsPINVOKE.UsdLuxSphereLight_Get(UsdStageWeakPtr.getCPtr(stage), SdfPath.getCPtr(path)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public static UsdLuxSphereLight Define(UsdStageWeakPtr stage, SdfPath path)
        {
            UsdLuxSphereLight ret = new UsdLuxSphereLight(UsdCsPINVOKE.UsdLuxSphereLight_Define(UsdStageWeakPtr.getCPtr(stage), SdfPath.getCPtr(path)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute GetRadiusAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdLuxSphereLight_GetRadiusAttr(swigCPtr), true);
            return ret;
        }

        public UsdAttribute CreateRadiusAttr(VtValue defaultValue, bool writeSparsely)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdLuxSphereLight_CreateRadiusAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateRadiusAttr(VtValue defaultValue)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdLuxSphereLight_CreateRadiusAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateRadiusAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdLuxSphereLight_CreateRadiusAttr__SWIG_2(swigCPtr), true);
            return ret;
        }

        public UsdAttribute GetTreatAsPointAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdLuxSphereLight_GetTreatAsPointAttr(swigCPtr), true);
            return ret;
        }

        public UsdAttribute CreateTreatAsPointAttr(VtValue defaultValue, bool writeSparsely)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdLuxSphereLight_CreateTreatAsPointAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateTreatAsPointAttr(VtValue defaultValue)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdLuxSphereLight_CreateTreatAsPointAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateTreatAsPointAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdLuxSphereLight_CreateTreatAsPointAttr__SWIG_2(swigCPtr), true);
            return ret;
        }
    }
}