﻿import { LOG_IN, LOG_OUT } from '../actions/types';

export default (state = false, action) => {
    switch (action.type) {
        case LOG_IN:
            return action.payload;
        case LOG_OUT:
            return false;
        default:
            return state;
    }
};