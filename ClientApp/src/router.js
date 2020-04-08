import Vue from 'vue';
import Router from 'vue-router';
import Home from './components/Home/Home';
import Login from './components/Login/Login';
import Stores from './components/Stores/Stores';
import StoreDetails from './components/Stores/StoreDetails';
import EmployeeDetails from './components/Employees/EmployeeDetails';


Vue.use(Router);

export default new Router({
    routes: [
        {
            path: '/',
            nome: 'Home',
            component: Home
        },
        {
            path: '/Login',
            nome: 'Login',
            component: Login
        },
        {
            path: '/Stores',
            nome: 'Stores',
            component: Stores
        },
        {
            path: '/StoreDetails',
            nome: 'StoreDetails',
            component: StoreDetails
        },
        {
            path: '/StoreDetails/:Store_id',
            nome: 'StoreDetails',
            component: StoreDetails
        },
        {
            path: '/EmployeeDetails',
            nome: 'EmployeeDetails',
            component: EmployeeDetails
        },
        {
            path: '/EmployeeDetails/:Employee_id',
            nome: 'EmployeeDetails',
            component: EmployeeDetails
        }
    ]
})