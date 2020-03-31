<template>
  <div>
    <titulo titulo="Lista de Lojas" />
    <div class="content">
      <table>
        <thead>
          <tr>
            <th style="width: 15%">Loja</th>
            <th>Localização</th>
            <th><div class="divemp">Empregados</div> Data de Admissão</th>
            <!--<th>Data Admissão</th> -->
          </tr>
        </thead>
        <tbody>
          <tr v-for="(item, index) in stores" :key="index">
            <router-link
              :to="'/LojaDetalhe/' + item.id"
              tag="td" class=" clickable txt-center">
              <strong>{{item.name}}</strong>
            </router-link>
            <td class="txt-center">
              <iframe
                :src="'https://maps.google.com/maps?q=\''+item.location+'&hl=pt-br&z=14&amp;output=embed'"
                width="380"
                height="300"
                frameborder="0"
                style="border:0;"
                allowfullscreen
                aria-hidden="false"
                tabindex="0"
              ></iframe>
              <br />
              <small class="txt-center">{{item.location}}</small>
            </td>

            <td  class="txt-left">
              <div v-for="(employees, eindex) in item.employees" :key="eindex">
                <router-link
              :to="'/EmployeeDetails/' + employees.id"
              tag="div"  class="divemp clickable">
                <strong>{{employees.name}}</strong>
                </router-link>
                
                {{employees.dateAdmission.slice(8,10)+'/'+employees.dateAdmission.slice(5,7)+'/'+employees.dateAdmission.slice(0,4)}}
                
                <br><br>
              </div>
            </td>
          </tr>
        </tbody>
      </table>
    </div>
  </div>
</template>

<script>
import Titulo from "../../components/_shared/_titulo";

export default {
  components: {
    Titulo
  },
  data() {
    return {
      stores: [
        {
          id: 1,
          name: "St Monica",
          location: "Av. Me. Benvenuta, 123 - Trindade, Florianópolis - SC",
          user: null,
          userId: 1,
          employees: [
            {
              id: 1,
              name: "Bob Brown",
              dateAdmission: "1998-04-21T00:00:00",
              baseSalary: 1000.0,
              storeId: 1,
              vacations: []
            },
            {
              id: 2,
              name: "Maria Green",
              dateAdmission: "1979-12-31T00:00:00",
              baseSalary: 3500.0,
              storeId: 1,
              vacations: []
            },
            {
              id: 3,
              name: "Alex Grey",
              dateAdmission: "1988-01-15T00:00:00",
              baseSalary: 2200.0,
              storeId: 1,
              vacations: []
            },
            {
              id: 4,
              name: "Martha Red",
              dateAdmission: "1993-11-30T00:00:00",
              baseSalary: 3000.0,
              storeId: 1,
              vacations: []
            },
            {
              id: 5,
              name: "Donald Blue",
              dateAdmission: "2000-01-09T00:00:00",
              baseSalary: 4000.0,
              storeId: 1,
              vacations: []
            },
            {
              id: 6,
              name: "Alex Pink",
              dateAdmission: "1997-03-04T00:00:00",
              baseSalary: 3000.0,
              storeId: 1,
              vacations: []
            },
            {
              id: 13,
              name: "XAle Punkaroo",
              dateAdmission: "1997-03-04T00:00:00",
              baseSalary: 3000.0,
              storeId: 1,
              vacations: []
            },
            {
              id: 14,
              name: "XAle Punkaroo",
              dateAdmission: "1997-03-04T00:00:00",
              baseSalary: 3000.0,
              storeId: 1,
              vacations: []
            }
          ]
        }
      ]
    };
  },
  methods: {}
};
</script>

<style scoped>
table {
  width: 100%;
  border-collapse: collapse;
  overflow: hidden;
  box-shadow: 0 0 20px var(--cor-terciaria);
}

td {
  padding: 15px;
  color: var(--cor-cinza2);
  background-image: linear-gradient(to top, var(--cor-secundaria), white);
}
th {
  min-width: 100px;
  text-align: left;
  padding: 15px;
  color: #fff;
}

thead {
  background-image: linear-gradient(
    45deg,
    var(--cor-principal2),
    var(--cor-secundaria)
  );
}

tbody {
  color: var(--cor-cinza2);
}
.txt-right {
  text-align: right;
  box-shadow: -2px 2px 4px white inset;
}
.txt-top {
  vertical-align: top;
}
.txt-center {
  text-align: center;
}
.txt-left {
  text-align: left;
  width: 100%;
}
.divemp {
  display: inline-flex;
  min-width: 150px;
  width: 20%;
}
</style>