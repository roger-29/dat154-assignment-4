import { LOG_IN, LOG_OUT, GET_ROOMS, BOOK_ROOM } from './types';
import axios from 'axios';

export const login = (user, history) => async dispatch => {
  const res = await axios.post('api/login', user);
  dispatch({
    type: LOG_IN,
    payload: res.data
  });
  history.push('/home');
};

export const logout = () => async dispatch => {
  dispatch({
    type: LOG_OUT
  });
};

export const getRooms = () => async dispatch => {
  const res = await axios.get('api/home');
    dispatch({
        type: GET_ROOMS,
        payload: res.data
  });
};

export const bookRoom = room => async dispatch => {
  const res = await axios.post('api/home', room);
    dispatch({
        type: BOOK_ROOM,
        payload: res.data
  });
};
