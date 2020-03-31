<template>
  <div>
    <titulo :titulo="'Detalhe Empregado '+ employee[0].name" />
    <div class="content">
      <div class="empdata">
                    <span style="display: inline-block; width: 200px;"><label for="name">Nome:</label></span>
                    <input type="text" name="name" id="name" v-model="employee[0].name" /><br>
                    <span style="display: inline-block; width: 200px;"><label for="dateadmission">Data de Admissão:</label></span>
                    <input
                      type="date"
                      name="dateadmission"
                      id="dateadmission"
                      v-model="employee[0].dateAdmission"
                    /><br>
                    <span style="display: inline-block; width: 200px;"><label for="basesalary">Salário:</label></span>
                    <input
                      type="text"
                      name="basesalary"
                      id="basesalary"
                      v-model="employee[0].baseSalary"
                    /><br>
                    <span style="display: inline-block; width: 200px;"><label for="storeId">Empregado na loja Id:</label></span>
                    <input
                      type="text"
                      name="storeId"
                      id="storeId"
                      v-model="employee[0].storeId"
                    /><br>
              </div>
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
              <span style="margin-left: 16px; display: block; text-align: left;">
              Férias agendadas:
              </span>
              <div id="myProgress">
                <div
                  v-for="(item, index) in employee[0].vacations"
                  :key="index"
                  class="lineProgress"
                >
                  <div class="empName">{{item.initDate.slice(0,4)}}</div>
                  <div
                    v-on:click="eventfocus"
                    class="myBar clickable tooltip"
                    :style="'left: ' + CalcBar(item.initDate, item.vacationDays)[0] + '%; width: ' + CalcBar(item.initDate, item.vacationDays)[1]+'%'"
                  >
                    <span class="tooltiptext">
                      <label for="initdate">Data de início:</label>
                      <br />
                      <input type="date" style="width: 176px" v-model="item.initDate" />

                      <label for="initdate">Quantidade dias:</label>
                      <br />
                      <input type="text" v-model="item.vacationDays" />
                    </span>
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
      editdata: "",
      employee: [
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
        }
      ]
    };
  },
  methods: {
    //falta o get e o post para salvar os dados
    CalcBar: function(vacationStart, vacationDays) {
      var lBar = 0;
      var wBar = 0;
      //var ano = vacationStart.splice(0,4);
      var mes = vacationStart.slice(5, 7);
      var dia = vacationStart.slice(8, 10);
      lBar = 825 * (mes - 1);
      lBar += 27.5 * dia;
      wBar = vacationDays * 0.278;
      lBar /= 100;
      return [lBar, wBar];
    },
    eventfocus: function(e) {
      if (e.toElement.className == "myBar clickable tooltip") {
        e.toElement.lastElementChild.lastElementChild.focus();
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
  text-align: left;
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
  opacity: 90%;
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
  white-space: pre-line;
  z-index: 5;
  visibility: hidden;
  width: auto;
  background-color: black;
  color: #fff;
  text-align: center;
  border-radius: 6px;
  padding: 5px 0;
  position: absolute;
  z-index: 1;
  bottom: 150%;
  left: 25%;
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
.tooltip:focus-within .tooltiptext:focus-within {
  visibility: visible;
  opacity: 90%;
}
.myBar:focus-within .myBartext:focus-within {
  visibility: visible;
  opacity: 90%;
}
.tooltip:hover .tooltiptext {
  visibility: visible;
  opacity: 90%;
}
button {
  margin-top: 5px;
  outline: none;
  float: right;
  border: none;
  padding: 8px 15px 8px 15px;
  background-color: var(--cor-clara);
  background-image: linear-gradient(
    45deg,
    var(--cor-secundaria),
    var(--cor-clara)
  );
  color: var(--cor-cinza);
  box-shadow: 1px 1px 4px black;
  border-radius: 4px;
}
button:active {
  transition: 200ms;
  background-image: none;
  box-shadow: 0px 0px 0px;
}
.empdata {
  width: 100%;
  margin-bottom: 16px;
  text-align: left;
}
.empdata input {
  margin: 5px;
  width: 200px;
}

</style>