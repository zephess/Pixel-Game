//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.11.2
//     from Assets/New Controls.inputactions
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

public partial class @NewControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @NewControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""New Controls"",
    ""maps"": [
        {
            ""name"": ""New action map"",
            ""id"": ""a0fc95e1-0729-434b-9763-9167c17d3cd9"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""6cf712a4-35f2-485a-9088-bf3c37680ab2"",
                    ""expectedControlType"": ""Analog"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""13b3cddf-6c56-413d-8d36-ffab4d2cf14a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""02e704e6-29fc-4715-9387-015671504250"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""e9f858b7-ca94-4ac1-a760-7b1474aae997"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""2f897d8b-98ca-449c-bb7a-63ef22e12a46"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""2325b8e1-c688-42c0-8275-b93fe48710f6"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""8b9175b9-a016-4650-b809-6357abcef521"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f8e0e65a-97d0-4ff3-8c3d-e74a04b71239"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // New action map
        m_Newactionmap = asset.FindActionMap("New action map", throwIfNotFound: true);
        m_Newactionmap_Movement = m_Newactionmap.FindAction("Movement", throwIfNotFound: true);
        m_Newactionmap_Jump = m_Newactionmap.FindAction("Jump", throwIfNotFound: true);
        m_Newactionmap_Attack = m_Newactionmap.FindAction("Attack", throwIfNotFound: true);
    }

    ~@NewControls()
    {
        UnityEngine.Debug.Assert(!m_Newactionmap.enabled, "This will cause a leak and performance issues, NewControls.Newactionmap.Disable() has not been called.");
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

    // New action map
    private readonly InputActionMap m_Newactionmap;
    private List<INewactionmapActions> m_NewactionmapActionsCallbackInterfaces = new List<INewactionmapActions>();
    private readonly InputAction m_Newactionmap_Movement;
    private readonly InputAction m_Newactionmap_Jump;
    private readonly InputAction m_Newactionmap_Attack;
    public struct NewactionmapActions
    {
        private @NewControls m_Wrapper;
        public NewactionmapActions(@NewControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Newactionmap_Movement;
        public InputAction @Jump => m_Wrapper.m_Newactionmap_Jump;
        public InputAction @Attack => m_Wrapper.m_Newactionmap_Attack;
        public InputActionMap Get() { return m_Wrapper.m_Newactionmap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(NewactionmapActions set) { return set.Get(); }
        public void AddCallbacks(INewactionmapActions instance)
        {
            if (instance == null || m_Wrapper.m_NewactionmapActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_NewactionmapActionsCallbackInterfaces.Add(instance);
            @Movement.started += instance.OnMovement;
            @Movement.performed += instance.OnMovement;
            @Movement.canceled += instance.OnMovement;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @Attack.started += instance.OnAttack;
            @Attack.performed += instance.OnAttack;
            @Attack.canceled += instance.OnAttack;
        }

        private void UnregisterCallbacks(INewactionmapActions instance)
        {
            @Movement.started -= instance.OnMovement;
            @Movement.performed -= instance.OnMovement;
            @Movement.canceled -= instance.OnMovement;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @Attack.started -= instance.OnAttack;
            @Attack.performed -= instance.OnAttack;
            @Attack.canceled -= instance.OnAttack;
        }

        public void RemoveCallbacks(INewactionmapActions instance)
        {
            if (m_Wrapper.m_NewactionmapActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(INewactionmapActions instance)
        {
            foreach (var item in m_Wrapper.m_NewactionmapActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_NewactionmapActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public NewactionmapActions @Newactionmap => new NewactionmapActions(this);
    public interface INewactionmapActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
    }
}
