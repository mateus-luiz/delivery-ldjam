//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.1
//     from Assets/InputActions/MotorcycleActions.inputactions
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

public partial class @MotorcycleActions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @MotorcycleActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MotorcycleActions"",
    ""maps"": [
        {
            ""name"": ""MotorcycleInputs"",
            ""id"": ""2522c6e3-0ae7-4a4f-9306-bd90019e910b"",
            ""actions"": [
                {
                    ""name"": ""Brake"",
                    ""type"": ""Button"",
                    ""id"": ""0be967d4-e79d-4d0f-ac6b-f86672ada1e5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Direction"",
                    ""type"": ""Value"",
                    ""id"": ""d7c17885-dc92-4569-a6e4-b2d17ded305b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""58a25ba0-00b7-46b7-9e47-5044cfee86b7"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""df03bbd9-a95c-4ad0-9ed8-7309334cf558"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""69d162fd-5fd9-4a41-a8fb-452a7fd451ee"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""240e16c5-5e66-4e0b-b856-7e0c35b187f9"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4700ca80-0ccc-48f6-8dc8-891923b34b98"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""57539732-f48c-4bdf-9c06-54073f53fd26"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // MotorcycleInputs
        m_MotorcycleInputs = asset.FindActionMap("MotorcycleInputs", throwIfNotFound: true);
        m_MotorcycleInputs_Brake = m_MotorcycleInputs.FindAction("Brake", throwIfNotFound: true);
        m_MotorcycleInputs_Direction = m_MotorcycleInputs.FindAction("Direction", throwIfNotFound: true);
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

    // MotorcycleInputs
    private readonly InputActionMap m_MotorcycleInputs;
    private List<IMotorcycleInputsActions> m_MotorcycleInputsActionsCallbackInterfaces = new List<IMotorcycleInputsActions>();
    private readonly InputAction m_MotorcycleInputs_Brake;
    private readonly InputAction m_MotorcycleInputs_Direction;
    public struct MotorcycleInputsActions
    {
        private @MotorcycleActions m_Wrapper;
        public MotorcycleInputsActions(@MotorcycleActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Brake => m_Wrapper.m_MotorcycleInputs_Brake;
        public InputAction @Direction => m_Wrapper.m_MotorcycleInputs_Direction;
        public InputActionMap Get() { return m_Wrapper.m_MotorcycleInputs; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MotorcycleInputsActions set) { return set.Get(); }
        public void AddCallbacks(IMotorcycleInputsActions instance)
        {
            if (instance == null || m_Wrapper.m_MotorcycleInputsActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MotorcycleInputsActionsCallbackInterfaces.Add(instance);
            @Brake.started += instance.OnBrake;
            @Brake.performed += instance.OnBrake;
            @Brake.canceled += instance.OnBrake;
            @Direction.started += instance.OnDirection;
            @Direction.performed += instance.OnDirection;
            @Direction.canceled += instance.OnDirection;
        }

        private void UnregisterCallbacks(IMotorcycleInputsActions instance)
        {
            @Brake.started -= instance.OnBrake;
            @Brake.performed -= instance.OnBrake;
            @Brake.canceled -= instance.OnBrake;
            @Direction.started -= instance.OnDirection;
            @Direction.performed -= instance.OnDirection;
            @Direction.canceled -= instance.OnDirection;
        }

        public void RemoveCallbacks(IMotorcycleInputsActions instance)
        {
            if (m_Wrapper.m_MotorcycleInputsActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMotorcycleInputsActions instance)
        {
            foreach (var item in m_Wrapper.m_MotorcycleInputsActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MotorcycleInputsActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MotorcycleInputsActions @MotorcycleInputs => new MotorcycleInputsActions(this);
    public interface IMotorcycleInputsActions
    {
        void OnBrake(InputAction.CallbackContext context);
        void OnDirection(InputAction.CallbackContext context);
    }
}
