<template>
  <div>
    <titulo :titulo="'Detalhe Loja '+ stores[0].name" />
    <div class="content">
      <table>
        <thead>
          <tr>
            <th>01</th>
            <th>02</th>
            <th>03</th>
            <th>04</th>
            <th>05</th>
            <th>06</th>
            <th>07</th>
            <th>08</th>
            <th>09</th>
            <th>10</th>
            <th>11</th>
            <th>12</th>
          </tr>
        </thead>
        <tbody>
          <tr>
            <td colspan="12" class="progressBar">
              <span
                style="margin-left: 16px; display: block; text-align: left;"
              >{{stores[0].id + ' - ' + stores[0].name}}</span>
              <div id="myProgress">
                <div
                  v-for="(employee, index) in stores[0].employees"
                  :key="index"
                  class="lineProgress"
                >
                  <div class="empName clickable">{{employee.name}}</div>
                  <div v-for="(vacation, index2) in employee.vacations" :key="index2">
                    <div
                      v-if="vacation.initDate.slice(0,4) == 2020"
                      v-on:click="EditaVacation"
                      class="myBar clickable tooltip"
                      :style="'left: ' + CalcBar(vacation)[0] + '%; width: ' + CalcBar(vacation)[1]+'%'"
                    >
                      <span class="tooltiptext">
                        <label for="vacationinit">Data saída:</label>
                        <input
                          v-model="vacation.initDate"
                          type="date"
                          name="vacationinit"
                          style="width: 175px"
                        />
                        Data volta:
                        {{CalcDataVolta(vacation.initDate, vacation.vacationDays)}}
                        <label
                          for="vacationdays"
                        >
                          Quantidade de dias:
                          <input
                            v-model="vacation.vacationDays"
                            type="number"
                            name="vacationdays"
                          />
                        </label>
                      </span>
                    </div>
                  </div>
                </div>
              </div>
            </td>
          </tr>
        </tbody>
      </table>
      <button>Salvar alterações</button>
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
      lojaid: this.$route.params.loja_id,
      stores: [
        {
          id: 1,
          name: "St Monica",
          location: "Av. Madre Benvenuta",
          user: null,
          userId: 1,
          employees: [
            {
              id: 1,
              name: "Bob Brown",
              dateAdmission: "1998-04-21",
              baseSalary: 1000.0,
              store: null,
              storeId: 1,
              vacations: [
                {
                  id: 1,
                  initDate: "2020-01-25",
                  vacationDays: 30,
                  employeeId: 1
                },
                {
                  id: 4,
                  initDate: "2018-09-01",
                  vacationDays: 30,
                  employeeId: 1
                },
                {
                  id: 6,
                  initDate: "2018-09-15",
                  vacationDays: 30,
                  employeeId: 1
                },
                {
                  id: 15,
                  initDate: "2018-09-12",
                  vacationDays: 30,
                  employeeId: 1
                },
                {
                  id: 17,
                  initDate: "2018-10-01",
                  vacationDays: 30,
                  employeeId: 1
                },
                {
                  id: 27,
                  initDate: "2018-10-13",
                  vacationDays: 30,
                  employeeId: 1
                }
              ]
            },
            {
              id: 2,
              name: "Maria Green",
              dateAdmission: "1979-12-31",
              baseSalary: 3500.0,
              store: null,
              storeId: 1,
              vacations: [
                {
                  id: 7,
                  initDate: "2019-03-28",
                  vacationDays: 30,
                  employeeId: 2
                },
                {
                  id: 11,
                  initDate: "2020-03-13",
                  vacationDays: 30,
                  employeeId: 2
                },
                {
                  id: 21,
                  initDate: "2018-10-17",
                  vacationDays: 30,
                  employeeId: 2
                },
                {
                  id: 23,
                  initDate: "2018-10-19",
                  vacationDays: 30,
                  employeeId: 2
                },
                {
                  id: 30,
                  initDate: "2018-10-12",
                  vacationDays: 30,
                  employeeId: 2
                }
              ]
            },
            {
              id: 3,
              name: "Alex Grey",
              dateAdmission: "1988-01-15",
              baseSalary: 2200.0,
              store: null,
              storeId: 1,
              vacations: [
                {
                  id: 5,
                  initDate: "2019-09-21",
                  vacationDays: 30,
                  employeeId: 3
                },
                {
                  id: 12,
                  initDate: "2018-09-25",
                  vacationDays: 30,
                  employeeId: 3
                },
                {
                  id: 18,
                  initDate: "2018-10-24",
                  vacationDays: 30,
                  employeeId: 3
                },
                {
                  id: 25,
                  initDate: "2018-10-31",
                  vacationDays: 30,
                  employeeId: 3
                },
                {
                  id: 28,
                  initDate: "2020-10-07",
                  vacationDays: 30,
                  employeeId: 3
                }
              ]
            },
            {
              id: 4,
              name: "Martha Red",
              dateAdmission: "1993-11-30",
              baseSalary: 3000.0,
              storeId: 1,
              vacations: [
                {
                  id: 29,
                  initDate: "2020-02-20",
                  vacationDays: 30,
                  employeeId: 4
                }
              ]
            },
            {
              id: 5,
              name: "Donald Blue",
              dateAdmission: "2000-01-09",
              baseSalary: 4000.0,
              storeId: 1,
              vacations: [
                {
                  id: 30,
                  initDate: "2020-06-01",
                  vacationDays: 30,
                  employeeId: 5
                }
              ]
            },
            {
              id: 6,
              name: "Alex Pink",
              dateAdmission: "1997-03-04",
              baseSalary: 3000.0,
              storeId: 1,
              vacations: [
                {
                  id: 31,
                  initDate: "2020-06-30",
                  vacationDays: 30,
                  employeeId: 6
                }
              ]
            },
            {
              id: 13,
              name: "XAle Punkaroo",
              dateAdmission: "1997-03-04",
              baseSalary: 3000.0,
              storeId: 1,
              vacations: [
                {
                  id: 32,
                  initDate: "2020-12-15",
                  vacationDays: 15,
                  employeeId: 13
                }
              ]
            },
            {
              id: 14,
              name: "XAle Punkaroo",
              dateAdmission: "1997-03-04",
              baseSalary: 3000.0,
              storeId: 1,
              vacations: [
                {
                  id: 33,
                  initDate: "2020-04-12",
                  vacationDays: 120,
                  employeeId: 14
                }
              ]
            }
          ]
        }
      ]
    };
  },
  created() {
    //carregar 
  },
  methods: {
    CalcBar: function(vacation) {
      var lBar = 0;
      var wBar = 0;
      var mes = vacation.initDate.slice(5, 7);
      var dia = vacation.initDate.slice(8, 10);
      lBar = 834 * (mes - 1);
      lBar += 27 * dia;
      lBar /= 100;
      wBar = vacation.vacationDays * 0.3;

      return [lBar, wBar];
    },
    CalcDataVolta: function(date, vacationDays) {
      var result = new Date(date);
      result.setDate(result.getDate() + vacationDays);
      return result.toLocaleDateString();
    },
    EditaVacation: function(e) {
      this.editing = true;
      if (e.toElement.className == "myBar clickable tooltip") {
        e.target.children[0].children[1].focus();
      }
    }
  }
};
</script>

<style scoped>
table {
  text-align: center;
  width: 100%;
  border-collapse: collapse;
  box-shadow: 0 0 20px var(--cor-terciaria);
}

td {
  padding: 6px;
  color: var(--cor-cinza2);
  background-image: linear-gradient(to top, var(--cor-secundaria), white);
}
.progressBar {
  padding: 0px;
}

th {
  text-align: left;
  padding: 15px 0px;
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
#myProgress {
  vertical-align: middle;
  border-radius: 25px;
  position: relative;
  float: left;
  margin-top: 0px;
  margin-left: 0px;
  width: 100%;
  background-color: var(--cor-terciaria);
}

.myBar {
  position: relative;
  z-index: 2;
  border-radius: 1em;
  height: 1.5em;
  background-color: var(--cor-principal2);
  opacity: 50%;
}
.lineProgress {
  box-shadow: 0 0 1px #fff;
  padding-top: 2px;
  padding-bottom: 2px;
  height: 1.5e;
}
.empName {
  position: absolute;
  width: 100%;
  margin-top: 3px;
  z-index: 1;
  color: #fff;
  text-shadow: 1px 1px 4px #000;
}

.tooltip .tooltiptext {
  z-index: 5;
  visibility: hidden;
  width: 180px;
  background-color: black;
  color: #fff;
  text-align: center;
  border-radius: 6px;
  padding: 5px 0;
  position: absolute;
  z-index: 1;
  bottom: 150%;
  left: 20%;
  margin-left: -60px;
}

.tooltip .tooltiptext::after {
  content: "";
  position: absolute;
  top: 100%;
  left: 50%;
  margin-left: -5px;
  border-width: 5px;
  border-style: solid;
  border-color: black transparent transparent transparent;
}

.tooltip:hover .tooltiptext {
  visibility: visible;
}
.tooltip:focus-within .tooltiptext:focus-within {
  visibility: visible;
  opacity: 90%;
}
.myBar:focus-within .myBartext:focus-within {
  visibility: visible;
  opacity: 90%;
}
.myBar:hover {
  opacity: 90%;
}

button {
  outline: none;
  border: none;
  float: right;
  margin-top: 5px;
  padding: 8px 15px 8px 15px;
  background-color: var(--cor-clara);
  background-image: linear-gradient(
    45deg,
    var(--cor-secundaria),
    var(--cor-clara)
  );
  color: var(--cor-cinza);
  box-shadow: 1px 1px 4px black;
  border-radius: 3px;
}
button:hover {
  background: #ea7b00;
  color: #fff;
}
button:active {
  transition: 200ms;
  background-image: none;
  box-shadow: 0px 0px 0px;
}
</style>