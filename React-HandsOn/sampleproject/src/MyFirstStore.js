import { createStore } from 'reduxjs'
// Reducer
function counter (state = { value: 0 }, action) {
  switch (action.type) {
  case 'INCREMENT':
    return { value: state.value + 1 }
  case 'DECREMENT':
    return { value: state.value - 1 }
  default:
    return state
  }
}
let store = createStore(counter)

// Dispatches an action; this changes the state
store.dispatch({ type: 'INCREMENT' })
store.dispatch({ type: 'DECREMENT' })
// Gets the current state
store.getState()
// Listens for changes
// store.subscribe(() => { ... })