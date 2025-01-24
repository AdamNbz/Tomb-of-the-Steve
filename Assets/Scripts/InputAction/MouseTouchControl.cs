//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.11.2
//     from Assets/Scripts/InputAction/MouseTouchControl.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @MouseTouchControl: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @MouseTouchControl()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MouseTouchControl"",
    ""maps"": [
        {
            ""name"": ""Touch"",
            ""id"": ""b092bcd5-3c77-4815-ab6d-a5f0d6699556"",
            ""actions"": [
                {
                    ""name"": ""ScreenTouch"",
                    ""type"": ""PassThrough"",
                    ""id"": ""5d500f5e-521f-4849-a815-67892d86164f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)"",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""ScreenHold"",
                    ""type"": ""PassThrough"",
                    ""id"": ""a47166ad-92a8-4fa7-86f6-842813918a1f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""43731971-f58a-43c1-af29-d6bfdcac106f"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ScreenTouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3de30b77-bc51-4a90-991f-9fef4813f18c"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ScreenHold"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Touch
        m_Touch = asset.FindActionMap("Touch", throwIfNotFound: true);
        m_Touch_ScreenTouch = m_Touch.FindAction("ScreenTouch", throwIfNotFound: true);
        m_Touch_ScreenHold = m_Touch.FindAction("ScreenHold", throwIfNotFound: true);
    }

    ~@MouseTouchControl()
    {
        UnityEngine.Debug.Assert(!m_Touch.enabled, "This will cause a leak and performance issues, MouseTouchControl.Touch.Disable() has not been called.");
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Touch
    private readonly InputActionMap m_Touch;
    private List<ITouchActions> m_TouchActionsCallbackInterfaces = new List<ITouchActions>();
    private readonly InputAction m_Touch_ScreenTouch;
    private readonly InputAction m_Touch_ScreenHold;
    public struct TouchActions
    {
        private @MouseTouchControl m_Wrapper;
        public TouchActions(@MouseTouchControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @ScreenTouch => m_Wrapper.m_Touch_ScreenTouch;
        public InputAction @ScreenHold => m_Wrapper.m_Touch_ScreenHold;
        public InputActionMap Get() { return m_Wrapper.m_Touch; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TouchActions set) { return set.Get(); }
        public void AddCallbacks(ITouchActions instance)
        {
            if (instance == null || m_Wrapper.m_TouchActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_TouchActionsCallbackInterfaces.Add(instance);
            @ScreenTouch.started += instance.OnScreenTouch;
            @ScreenTouch.performed += instance.OnScreenTouch;
            @ScreenTouch.canceled += instance.OnScreenTouch;
            @ScreenHold.started += instance.OnScreenHold;
            @ScreenHold.performed += instance.OnScreenHold;
            @ScreenHold.canceled += instance.OnScreenHold;
        }

        private void UnregisterCallbacks(ITouchActions instance)
        {
            @ScreenTouch.started -= instance.OnScreenTouch;
            @ScreenTouch.performed -= instance.OnScreenTouch;
            @ScreenTouch.canceled -= instance.OnScreenTouch;
            @ScreenHold.started -= instance.OnScreenHold;
            @ScreenHold.performed -= instance.OnScreenHold;
            @ScreenHold.canceled -= instance.OnScreenHold;
        }

        public void RemoveCallbacks(ITouchActions instance)
        {
            if (m_Wrapper.m_TouchActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ITouchActions instance)
        {
            foreach (var item in m_Wrapper.m_TouchActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_TouchActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public TouchActions @Touch => new TouchActions(this);
    public interface ITouchActions
    {
        void OnScreenTouch(InputAction.CallbackContext context);
        void OnScreenHold(InputAction.CallbackContext context);
    }
}
